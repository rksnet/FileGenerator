
using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace FileGeneratorApp
{
    [XmlRoot(ElementName = "CommonDetails")]
    public class CommonDetails
    {
        [XmlElement(ElementName = "Separater")]
        public string Separater { get; set; }
        [XmlElement(ElementName = "FileName")]
        public string FileName { get; set; }
    }

    [XmlRoot(ElementName = "HeaderDetails")]
    public class HeaderDetails
    {
        [XmlElement(ElementName = "ID")]
        public string ID { get; set; }
        [XmlElement(ElementName = "FirstName")]
        public string FirstName { get; set; }
        [XmlElement(ElementName = "Lastname")]
        public string Lastname { get; set; }
        [XmlElement(ElementName = "Amount")]
        public string Amount { get; set; }
    }

    [XmlRoot(ElementName = "ID")]
    public class ID
    {
        [XmlAttribute(AttributeName = "Datatype")]
        public string Datatype { get; set; }
        [XmlAttribute(AttributeName = "Identity")]
        public string Identity { get; set; }
        [XmlAttribute(AttributeName = "NegativeValue")]
        public string NegativeValue { get; set; }
    }

    [XmlRoot(ElementName = "FirstName")]
    public class FirstName
    {
        [XmlAttribute(AttributeName = "Datatype")]
        public string Datatype { get; set; }
        [XmlAttribute(AttributeName = "Length")]
        public string Length { get; set; }
        [XmlAttribute(AttributeName = "NegativeValue")]
        public string NegativeValue { get; set; }
    }

    [XmlRoot(ElementName = "Lastname")]
    public class Lastname
    {
        [XmlAttribute(AttributeName = "Datatype")]
        public string Datatype { get; set; }
        [XmlAttribute(AttributeName = "Length")]
        public string Length { get; set; }
        [XmlAttribute(AttributeName = "NegativeValue")]
        public string NegativeValue { get; set; }
    }

    [XmlRoot(ElementName = "Amount")]
    public class Amount
    {
        [XmlAttribute(AttributeName = "Datatype")]
        public string Datatype { get; set; }
        [XmlAttribute(AttributeName = "NegativeValue")]
        public string NegativeValue { get; set; }
    }

    [XmlRoot(ElementName = "Columns")]
    public class Columns
    {
        [XmlElement(ElementName = "ID")]
        public ID ID { get; set; }
        [XmlElement(ElementName = "FirstName")]
        public FirstName FirstName { get; set; }
        [XmlElement(ElementName = "Lastname")]
        public Lastname Lastname { get; set; }
        [XmlElement(ElementName = "Amount")]
        public Amount Amount { get; set; }

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
        public HeaderDetails HeaderDetails { get; set; }
        [XmlElement(ElementName = "Columns")]
        public Columns Columns { get; set; }
        [XmlElement(ElementName = "FooterDetails")]
        public FooterDetails FooterDetails { get; set; }
    }



}
