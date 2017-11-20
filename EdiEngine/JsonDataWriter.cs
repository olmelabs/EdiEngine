using System.IO;
using EdiEngine.Runtime;
using Newtonsoft.Json;

namespace EdiEngine
{
    public class JsonDataWriter : DataWriter
    {
        public override Stream WriteToStream(EdiBatch batch)
        {
            MemoryStream s = new MemoryStream();
            StreamWriter w = new StreamWriter(s);
            var serializer = new JsonSerializer();
            serializer.Serialize(w, batch);
            w.Flush();

            s.Position = 0;
            return s;
        }

        public override string WriteToString(EdiBatch batch)
        {
            return JsonConvert.SerializeObject(batch);
        }
    }
}
