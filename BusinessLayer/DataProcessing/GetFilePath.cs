using System;

using System.IO;

namespace BusinessLayer.DataProcessing
{
  public static class GetFilePath
    {
        private const string fileName = @"BusinessLayer\JsonFiles\en.locale1.json";
        private const string fileNameFormula = @"BusinessLayer\JsonFiles\en.Formula.json";
        private const string xmlFilePath = @"BusinessLayer\JsonFiles\XMLFIle.XML";
        public static string GetJsonFilePath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.LastIndexOf("FileGenerator")), fileName);
        }
        public static string GetJsonFilePathFormula()
        {
            var s=AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.LastIndexOf("FileGenerator")), fileNameFormula);
        }
        public static string GetXmlConfigFile()
        {
            var s = AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.LastIndexOf("FileGenerator")), xmlFilePath);
        }
    }
}
