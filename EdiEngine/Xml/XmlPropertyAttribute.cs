using System;

namespace EdiEngine.Xml
{
    [AttributeUsage(AttributeTargets.Property)]
    public class XmlPropertyAttribute : Attribute
    {
        public int Order { get; set; }
        public string PropertyName { get; set; }
    }
}