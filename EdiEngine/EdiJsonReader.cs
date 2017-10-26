using EdiEngine.Common.Definitions;
using EdiEngine.Runtime;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EdiEngine.Common.Enums;

namespace EdiEngine
{
    public class EdiJsonReader
    {

        private EdiTrans _trans;
        private EdiLoop _currentLoopInstance;
        private MapLoop _currentLoopDef;
        private StringBuilder _currentSegmentString;
        private MapBaseEntity _currentEntityDef;

        public EdiJsonReader(MapLoop map, EdiTrans currentTrans)
        {
            _trans = currentTrans;
            _currentLoopInstance = currentTrans;
            _currentLoopInstance.Definition = map;
            _currentLoopDef = map;
        }

        public EdiTrans ReadToEnd(string jsonTrans)
        {
            _trans = new EdiTrans((MapBaseEntity)_currentLoopDef);

            ReadJson(jsonTrans);

            return _trans;
        }

        private void ReadJson(string jsonTrans)
        {
            
            JsonTextReader reader = new JsonTextReader(new StringReader(jsonTrans));

            TokenContextType tokenContext = TokenContextType.None;
            int elementProcessing = 0;

            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.PropertyName)
                {
                    switch (reader.Value.ToString())
                    {
                        case "Name":
                            tokenContext = TokenContextType.Segment;
                            _currentSegmentString = new StringBuilder();
                            break;

                        case "E":
                            tokenContext = TokenContextType.DataElement;
                            break;

                        case "Content":
                            break;
                    }
                }
                else if (reader.TokenType == JsonToken.String)
                {
                    string val = reader.Value.ToString();
                    if (val.StartsWith("M_"))
                    {
                        tokenContext = TokenContextType.None;
                        continue;
                    }
                    ProcessToken(tokenContext, val);
                }
                //find end Segment after scanning all elements
                else if (reader.TokenType == JsonToken.StartObject && 
                    (tokenContext == TokenContextType.Segment || tokenContext == TokenContextType.DataElement))
                {
                    //found StartObject for element
                    elementProcessing++;
                }
                else if (reader.TokenType == JsonToken.EndObject && tokenContext == TokenContextType.DataElement)
                {
                    //found EndObject for element or Segment
                    elementProcessing--;
                    if (elementProcessing < 0) //it is end segment token
                    {
                        string segContent = _currentSegmentString.ToString();

                        _currentLoopInstance.Content.Add(EdiMapReader.ProcessSegment(_currentEntityDef, segContent.Split(new [] {'*'}), -1, _trans));

                        _currentSegmentString = null;
                        tokenContext = TokenContextType.None;
                    }
                }
            }
        }

        private void ProcessToken(TokenContextType token, string val)
        {
            switch (token)
            {
                case TokenContextType.Segment:
                    SetMapContext(val);

                    if (val.StartsWith("L_"))
                        return;

                    _currentSegmentString.Append(val);
                    break;

                case TokenContextType.DataElement:
                    _currentSegmentString.Append($"*{val}");
                    break;
            }

        }

        private void SetMapContext(string name)
        {
            List<AllowedEntitity> allowedEntities = GetNextAllowedEntities(_currentLoopDef);

            if (allowedEntities.All(e => e.Entity.EdiName != name))
            {
                string expected = string.Join(", ", allowedEntities.Select(e => e.Entity.Name).ToList());
                string msgPart = allowedEntities.Count > 1 ? "Expected one of" : "Expected";
                ValidationError err = new ValidationError()
                {
                    Message = $"Unexpected Segment. {msgPart} {expected}. Found {name}."
                };
                _trans.ValidationErrors.Add(err);
                return;
            }

            AllowedEntitity ae = allowedEntities.FirstOrDefault(e => e.Entity.EdiName == name);
            if (ae?.Entity is MapSegment)
            {
                ae.Entity.OccuredTimes++;

                _currentLoopDef = ae.LoopContext;
                _currentLoopDef.CurrentPos = _currentLoopDef.Content.IndexOf(ae.Entity);

                while (((MapLoop)_currentLoopInstance.Definition) != ae.LoopContext && _currentLoopInstance.Parent != null)
                {
                    _currentLoopInstance = _currentLoopInstance.Parent;
                }

                _currentEntityDef = ae.Entity;
            }
        }

        private enum TokenContextType
        {
            Segment,
            DataElement,
            None
        }


        private List<AllowedEntitity> GetNextAllowedEntities(MapLoop currentLoop)
        {
            List<AllowedEntitity> res = new List<AllowedEntitity>();
            MapBaseEntity be = currentLoop.Content[currentLoop.CurrentPos];

            if (be.ReqDes == RequirementDesignator.Mandatory && be.OccuredTimes == 0)
            {
                res.Add(new AllowedEntitity(be, currentLoop));
                return res;
            }

            if (be.OccuredTimes > 0 && be.OccuredTimes < be.MaxOccurs)
            {
                res.Add(new AllowedEntitity(be, currentLoop));
            }

            for (int i = currentLoop.CurrentPos + 1; i < currentLoop.Content.Count; i++)
            {
                res.Add(new AllowedEntitity(currentLoop.Content[i], currentLoop));
                if (currentLoop.Content[i].ReqDes == RequirementDesignator.Mandatory)
                    break;
            }

            //if in loop all except first  seg are optional, and max occurs not reached yet - return new loop iteration
            if (currentLoop.ParentLoop != null)
            {
                res.AddRange(GetNextAllowedEntities(currentLoop.ParentLoop));
            }
            return res;
        }
    }
}
