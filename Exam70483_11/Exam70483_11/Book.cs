using System;
using System.Xml.Serialization;

namespace Exam70483_11
{
    [Serializable]
    public class Book
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "author")]
        public string Author { get; set; }
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "genre")]
        public string Genre { get; set; }
        [XmlElement(ElementName = "price")]
        public double Price { get; set; }
        [XmlElement(ElementName = "publish_date")]
        public DateTime Publish_date { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
    }
}
