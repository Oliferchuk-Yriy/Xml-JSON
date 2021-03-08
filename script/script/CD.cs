using System;
using System.Xml.Serialization;

namespace script
{
    [Serializable]
    [XmlRoot("CATALOG")]
    public class Catalog
    {
        [XmlElement("CD")]
        public CD[] Cd { get; set; }
    }
    [Serializable]
    public class CD
    {
        [XmlElement("TITLE")]
        public string Title { get; set; }

        [XmlElement("ARTIST")]
        public string Artist { get; set; }

        [XmlElement("COUNTRY")]
        public string Country { get; set; }

        [XmlElement("COMPANY")]
        public string Company { get; set; }

        [XmlElement("PRICE")]
        public float Price { get; set; }

        [XmlElement("YEAR")]
        public int Year { get; set; }
    }
}
