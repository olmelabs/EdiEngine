using System;

namespace EdiEngine.Xml
{
    [AttributeUsage(AttributeTargets.Class)]
    public class XmlElementAttribute : Attribute
    {
        public bool IgnoreElementRoot { get; set; }
        public string ElementName { get; set; }
    }
}