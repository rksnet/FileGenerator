using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace BusinessLayer
{
    public class XmlProcessing
    {
        private string FilePath { get; set; }
        public int RecordCount { get; set; }
        public string DateFormat { get; set; }
        public char Delimeter { get; set; }
        public string OutputFilePath { get; set; }
        public string OutputFileName { get; set; }
        public string OutputFileType { get; set; }

        public bool IsValidXmlFile { get; set; }

        private IEnumerable<XElement> CommonData { get; set; }
        private IEnumerable<XElement> HeaderData { get; set; }
        private IEnumerable<XElement> RecordData { get; set; }
        private IEnumerable<XElement> FooterData { get; set; }
        
        public XmlProcessing(string filePath)
        {
            FilePath = filePath;
            IsValidXmlFile = IsValidXmlAndPath();
        }

        public bool ParseAndGenerateFile()
        {
            bool result = true;

            return result;
        }

        private bool IsValidXmlAndPath()
        {
            var regEx = new Regex(@"^(([a-zA-Z]:)|(\))(\{1}|((\{1})[^\]([^/:*?<>""|]*))+)$");
            return regEx.IsMatch(FilePath) & File.Exists(FilePath);
        }

        private void ReadXmlElement()
        {
            var xmlData = XElement.Load(FilePath);
            CommonData = xmlData.Elements("Common");
            HeaderData = xmlData.Elements("Common");
            RecordData = xmlData.Elements("Common");
            FooterData = xmlData.Elements("Common");
        }

    }
    static class ExtensionMethods
    {
        private static string TryGetElementValue(this XElement parentEl, string elementName, string defaultValue = null)
        {
            var foundEl = parentEl.Element(elementName);

            if (foundEl != null)
            {
                return foundEl.Value;
            }
            return defaultValue;
        }
    }
}