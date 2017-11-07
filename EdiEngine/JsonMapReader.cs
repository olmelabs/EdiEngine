using EdiEngine.Common.Definitions;
using EdiEngine.Runtime;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiEngine
{
    public class JsonMapReader : MapReader
    {
        private EdiTrans _trans;
        private EdiLoop _currentLoopInstance;
        private MapLoop _currentLoopDef;
        private MapBaseEntity _currentEntityDef;

        public JsonMapReader(MapLoop map)
        {
            _currentLoopDef = map;
        }

        public EdiTrans ReadToEnd(string rawJson)
        {
            _trans = new EdiTrans(_currentLoopDef);

            _currentLoopInstance = _trans;
            _currentLoopInstance.Definition = _currentLoopDef;

            EdiJsonEntity jsonTree = ReadJsonTree(rawJson);

            ParseTree(jsonTree);

            return _trans;
        }

        private void ParseTree(EdiJsonEntity jsonTreeNode)
        {
            foreach (EdiJsonEntity ent in jsonTreeNode.Children)
            {
                switch (ent.EntityType)
                {
                    case TokenContextType.Loop:
                        SetMapContext(ent.Name);
                        ParseTree(ent);
                        break;

                    case TokenContextType.Segment:
                        SetMapContext(ent.Name);

                        if (ent.Parent != null && !ent.Parent.Name.Equals(_currentLoopDef.Name))
                        {
                            ValidationError err = new ValidationError()
                            {
                                Message = $"Unexpected Segment at {ent.Parent.Name} > {ent.Name}."
                            };
                            _trans.ValidationErrors.Add(err);
                        }

                        List<string> segParts = new List<string> {ent.Name};
                        segParts.AddRange(ent.Children.Select(el => el.E));

                        EdiSegment seg = ProcessSegment(_currentEntityDef, segParts.ToArray(), -1, _trans);
                        _currentLoopInstance.Content.Add(seg);
                        break;
                }
            }
        }

        private EdiJsonEntity ReadJsonTree(string rawJson)
        {
            JsonTextReader reader = new JsonTextReader(new StringReader(rawJson));

            EdiJsonEntity jsonContext = new EdiJsonEntity(null);
            PropertyInfo jsonProp = null;

            while (reader.Read())
            {
                string val;
                switch (reader.TokenType)
                {
                    case JsonToken.StartObject:
                        var ent = new EdiJsonEntity(jsonContext);
                        jsonContext?.Children.Add(ent);
                        jsonContext = ent;
                        break;

                    case JsonToken.PropertyName:
                        val = reader.Value.ToString();
                        jsonProp = typeof(EdiJsonEntity).GetProperty(val);
                        break;

                    case JsonToken.String:
                        val = reader.Value.ToString();
                        jsonProp?.SetValue(jsonContext, val);
                        break;

                    case JsonToken.EndObject:
                        jsonContext = jsonContext?.Parent;
                        break;
                }
            }
            return jsonContext?.Children[0];
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
    }
}
