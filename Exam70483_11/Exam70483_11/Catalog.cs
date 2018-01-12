using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Exam70483_11
{
    [Serializable]
    [XmlRoot("catalog")]
    public class Catalog
    {
        [XmlElement(ElementName = "book")]
        public List<Book> Books { get; set; }
    }
}
