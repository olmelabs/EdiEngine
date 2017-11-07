using System.IO;


namespace EdiEngine.Tests
{
    public class TestUtils
    {
        public static string ReadResourceStream(string resourceName)
        {
            using (var s = typeof(TestUtils).Assembly.GetManifestResourceStream(resourceName))
            {
                if (s == null)
                    throw new InvalidDataException("stream is null");

                using (StreamReader sr = new StreamReader(s))
                {
                    return sr.ReadToEnd();
                }
            }
        }
    }
}
