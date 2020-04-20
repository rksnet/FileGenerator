using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataProcessing
{
    public class JsonData
    {
        private const string FILE_NAME = @"BusinessLayer\JsonFiles\en.locale.json";

        public List<string> MaleFirstNames { get; set; }
        public List<string> FemaleFirstNames { get; set; }
        public List<string> FirstNames { get; set; }
        public List<string> LastNames { get; set; }

        public JsonData()
        {
            PraseJsonFile(GetJsonFilePath());
        }
        public JsonData(string filePath)
        {
            PraseJsonFile(filePath);
        }

        /// <summary>
        /// Parse Json file and retirve list of nodes from given filepath
        /// </summary>
        /// <param name="filePath"></param>
        private void PraseJsonFile(string filePath)
        {
            JObject FileDataObj = JObject.Parse(File.ReadAllText(filePath));

            var data = ((JArray)FileDataObj["name"]["first_name"]);
            if (data != null)
            {
                FirstNames = data.Select(f => f.ToString()).ToList();
            }

            data = ((JArray)FileDataObj["name"]["last_name"]);
            if (data != null)
            {
                LastNames = data.Select(f => f.ToString()).ToList();
            }

            data = ((JArray)FileDataObj["name"]["male_first_name"]);
            if (data != null)
            {
                MaleFirstNames = data.Select(f => f.ToString()).ToList();
            }

            data = ((JArray)FileDataObj["name"]["female_first_name"]);
            if (data != null)
            {
                FemaleFirstNames = data.Select(f => f.ToString()).ToList();
            }
        }

        private string GetJsonFilePath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.LastIndexOf("FileGenerator")), FILE_NAME);
        }
    }
}
