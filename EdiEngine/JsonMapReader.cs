using EdiEngine.Common.Definitions;
using EdiEngine.Runtime;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;

namespace EdiEngine
{
    public class JsonMapReader : InetermediateFormatReader
    {
        public JsonMapReader(MapLoop map) : base(map)
        {
        }

        protected override EdiIntermediateEntity ReadIntermediateTree(string rawData)
        {
            JsonTextReader reader = new JsonTextReader(new StringReader(rawData));

            EdiIntermediateEntity context = new EdiIntermediateEntity(null);
            PropertyInfo prop = null;

            while (reader.Read())
            {
                string val;
                switch (reader.TokenType)
                {
                    case JsonToken.StartObject:
                        var ent = new EdiIntermediateEntity(context);
                        context?.Children.Add(ent);
                        context = ent;
                        break;

                    case JsonToken.PropertyName:
                        val = reader.Value.ToString();
                        prop = typeof(EdiIntermediateEntity).GetProperty(val);
                        break;

                    case JsonToken.String:
                        val = reader.Value.ToString();
                        prop?.SetValue(context, val);
                        break;

                    case JsonToken.EndObject:
                        context = context?.Parent;
                        break;
                }
            }
            return context?.Children[0];
        }
    }
}
