using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace BusinessLayer
{
    public class XmlProcessing
    {
        private const char DELIMITER_DEFAULT_VALUE = ',';
        private const string DATE_FORMAT_DEFAULT_VALUE = "MMDDYYYY";
        private const string OUTPUT_FILE_NAME_DEFAULT_VALUE = "FileExtract{mmDDyyyy}";
        private const int RECORD_COUNT_DEFAULT_VALUE = 10;

        private string FilePath { get; set; }
        public int RecordCount { get; set; }
        public string DateFormat { get; set; }
        public char Delimiter { get; set; }
        public string OutputFilePath { get; set; }
        public string OutputFileName { get; set; }
        public string OutputFileType { get; set; }

        private IEnumerable<XElement> CommonData { get; set; }
        private IEnumerable<XElement> HeaderData { get; set; }
        private IEnumerable<XElement> RecordData { get; set; }
        private IEnumerable<XElement> FooterData { get; set; }

        public XmlProcessing(string filePath)
        {
            FilePath = filePath;
        }

        public bool ParseAndGenerateFile()
        {
<<<<<<< HEAD
            if (File.Exists(FilePath))
            {
                ReadXmlElement();
                ReadCommonDetails();
            }
=======
            bool result = true;

            return result;
>>>>>>> bc791bc7eb456b1af1cb0e0bcdb0b3529922e383
        }

        private void ReadXmlElement()
        {
            var xmlData = XElement.Load(FilePath);
            CommonData = xmlData.Elements("CommonDetails");
            HeaderData = xmlData.Elements("HeaderDetails");
            RecordData = xmlData.Elements("RecordDetails");
            FooterData = xmlData.Elements("FooterDetails");
        }

        private void ReadCommonDetails()
        {
            if (CommonData.Any())
            {
                if (CommonData.Elements("Delimiter").Any() && Delimiter == '\0')
                {
                    Delimiter = CommonData.Elements("Delimiter").FirstOrDefault().Value == string.Empty ? DELIMITER_DEFAULT_VALUE : Convert.ToChar(CommonData.Elements("Delimiter").FirstOrDefault().Value);
                }
                if (CommonData.Elements("DateFormat").Any() && DateFormat == null)
                {
                    DateFormat = CommonData.Elements("DateFormat").FirstOrDefault().Value == string.Empty ? DATE_FORMAT_DEFAULT_VALUE : CommonData.Elements("DateFormat").FirstOrDefault().Value;
                }
                if (CommonData.Elements("FileName").Any() && OutputFileName == null)
                {
                    OutputFileName = CommonData.Elements("FileName").FirstOrDefault().Value == string.Empty ? OUTPUT_FILE_NAME_DEFAULT_VALUE : CommonData.Elements("FileName").FirstOrDefault().Value;
                }
                if (CommonData.Elements("RecordCount").Any() && RecordCount == 0)
                {
                    RecordCount = CommonData.Elements("RecordCount").FirstOrDefault().Value == string.Empty ? RECORD_COUNT_DEFAULT_VALUE : Convert.ToInt32(CommonData.Elements("RecordCount").FirstOrDefault().Value);
                }
                if (OutputFilePath == null)
                {
                    OutputFilePath = Path.GetDirectoryName(FilePath);
                }
            }
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