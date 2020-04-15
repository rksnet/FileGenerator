using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BusinessLayer.XMLMapping
{
   
    public class ColumnXmlDefination
    {
        /// <summary>
        /// This class will contain list columns defined in xml file.
        /// </summary>
        [XmlRoot(ElementName = "Columns")]
        public class Columns
        {
            [XmlElement(ElementName = "Column")]
            public List<Column> Column { get; set; }
        }

        /// <summary>
        /// This class has column attributes 
        /// </summary>
      [XmlRoot(ElementName = "Column")]
       public class Column
        {
            [XmlElement(ElementName = "Name")]
            public string Name { get; set; }

            [XmlElement(ElementName = "Datatype")]
            public string Datatype { get; set; }

            [XmlElement(ElementName = "NegativeValue")]
            public int NegativeValue { get; set; }

            [XmlElement(ElementName = "Prifix")]
            public int Prifix { get; set; }

            [XmlElement(ElementName = "Suffix")]
            public int Suffix { get; set; }

            [XmlElement(ElementName = "Length")]
            public int Length { get; set; }

            [XmlElement(ElementName = "MinLength")]
            public int MinLength { get; set; }

            [XmlElement(ElementName = "MaxLength")]
            public int MaxLength { get; set; }

            [XmlElement(ElementName = "StartDate")]
            public DateTime StartDate { get; set; }

            [XmlElement(ElementName = "EndDate")] 
            public DateTime EndDate { get; set; }

        }
    }
}
