using EdiEngine.Common.Definitions;
using EdiEngine.Runtime;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EdiEngine
{
    public class JsonMapReader : MapReader
    {

        private EdiTrans _trans;
        private EdiLoop _currentLoopInstance;
        private MapLoop _currentLoopDef;
        private StringBuilder _currentSegmentString;
        private MapBaseEntity _currentEntityDef;

        public JsonMapReader(MapLoop map, EdiTrans currentTrans)
        {
            _trans = currentTrans;
            _currentLoopInstance = currentTrans;
            _currentLoopInstance.Definition = map;
            _currentLoopDef = map;
        }

        public EdiTrans ReadToEnd(string jsonTrans)
        {
            _trans = new EdiTrans(_currentLoopDef);

            ReadJson(jsonTrans);

            return _trans;
        }

        private void ReadJson(string jsonTrans)
        {
            JsonTextReader reader = new JsonTextReader(new StringReader(jsonTrans));

            TokenContextType tokenContext = TokenContextType.None;
            int elementProcessing = 0;
            bool expectingName = false;

            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.PropertyName)
                {
                    string val = reader.Value.ToString();
                    switch (val)
                    {
                        case "E":
                            tokenContext = TokenContextType.DataElement;
                            break;

                        case "Name":
                            expectingName = true;
                            break;

                        case "Type":
                            tokenContext = TokenContextType.EntityType;
                            break;
                   }
                }
                else if (reader.TokenType == JsonToken.String)
                {
                    string val = reader.Value.ToString();
                    if (expectingName && (tokenContext == TokenContextType.Segment || tokenContext == TokenContextType.Loop))
                    {
                        SetMapContext(val);
                        expectingName = false;
                    }

                    if (tokenContext == TokenContextType.Segment || tokenContext == TokenContextType.DataElement)
                    {
                        ProcessToken(tokenContext, val);
                    }

                    if (tokenContext == TokenContextType.EntityType)
                    {
                        if (val == "S")
                            tokenContext = TokenContextType.Segment;
                        if (val == "L")
                            tokenContext = TokenContextType.Loop;
                    }
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

                        _currentLoopInstance.Content.Add(ProcessSegment(_currentEntityDef, segContent.Split(new[] { '*' }),
                            -1, _trans));

                        _currentSegmentString = null;
                        tokenContext = TokenContextType.None;
                        elementProcessing = 0;
                    }
                }
            }
        }

        private void ProcessToken(TokenContextType token, string val)
        {
            switch (token)
            {
                case TokenContextType.Segment:
                    _currentSegmentString = new StringBuilder();
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

            if (allowedEntities.All(e => e.Entity.Name != name))
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

            AllowedEntitity ae = allowedEntities.FirstOrDefault(e => e.Entity.Name == name);
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
            else if (ae?.Entity is MapLoop)
            {
                //find loop definition in map and reset counters
                ae.LoopContext.CurrentPos = ae.LoopContext.Content.IndexOf(ae.Entity);
                _currentLoopDef = (MapLoop)ae.Entity;
                _currentLoopDef.CurrentPos = 0;
                _currentLoopDef.OccuredTimes++;
                _currentLoopDef.Content.ForEach(c => c.OccuredTimes = 0);

                ////create new loop instance and add to transaction
                while (((MapLoop)_currentLoopInstance.Definition) != ae.LoopContext && _currentLoopInstance.Parent != null)
                {
                    _currentLoopInstance = _currentLoopInstance.Parent;
                }

                var newLoop = new EdiLoop(ae.Entity, _currentLoopInstance);
                _currentLoopInstance.Content.Add(newLoop);
                _currentLoopInstance = newLoop;
            }
        }

        private enum TokenContextType
        {
            EntityType,
            Loop,
            Segment,
            DataElement,
            None
        }
    }
}
