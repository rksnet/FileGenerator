using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using static BusinessLayer.XMLMapping.ColumnXmlDefination;

namespace BusinessLayer.XMLMapping
{
    /// <summary>
    /// This class has nodes other than columns to serialise the xml file 
    /// </summary>
  public  class ConcreteXmlClass
    {
        [XmlRoot(ElementName = "CommonDetails")]
        public class CommonDetails
        {
            [XmlElement(ElementName = "Separater")]
            public string Separater { get; set; }
            [XmlElement(ElementName = "FileName")]
            public string FileName { get; set; }
            [XmlElement(ElementName = "GenrateHeader")]
            public string GenrateHeader { get; set; }
        }

        [XmlRoot(ElementName = "RecordCount")]
        public class RecordCount
        {
            [XmlAttribute(AttributeName = "Value")]
            public string Value { get; set; }
        }

        [XmlRoot(ElementName = "FooterDetails")]
        public class FooterDetails
        {
            [XmlElement(ElementName = "RecordCount")]
            public RecordCount RecordCount { get; set; }
        }

        [XmlRoot(ElementName = "FileGenerator")]
        public class FileGenerator
        {
            [XmlElement(ElementName = "CommonDetails")]
            public CommonDetails CommonDetails { get; set; }
            [XmlElement(ElementName = "HeaderDetails")]
            public string HeaderDetails { get; set; }
            [XmlElement(ElementName = "Columns")]
            public Columns Columns { get; set; }
            [XmlElement(ElementName = "FooterDetails")]
            public FooterDetails FooterDetails { get; set; }
           
        }
    }
}
