using Common;
using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Spreadsheet;
using Newtonsoft.Json;
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
     
        public List<string> DataList { get; set; }
        public List<string> Firstname { get; set; }
        public List<string> LastNames { get; set; }

        public JsonData()
        {

        }
        /// <summary>
        /// Parse Json file and retirve list of nodes from given filepath
        /// </summary>
        /// <param name="filePath"></param>
        public List<string> GetData(string columnName)
        {
            string filePath =GetFilePath.GetJsonFilePath();
            JObject FileDataObj = JObject.Parse(File.ReadAllText(filePath));
            List<string> Nodes = new List<string>();
            ///creating a list of parent node f
            Nodes = ReadNode(FileDataObj);
            /// finding the exact match of passed collumn name in json column node 
            List<string> matchValue = (from val in Nodes
                                       where val.Like(columnName.ToLower())
                                       select val).ToList();

            ///parsing the json file which has fields defination mapping 
            JObject formulaJson = JObject.Parse(File.ReadAllText(GetFilePath.GetJsonFilePathFormula()));

            string formulaNodeName = string.Empty;
            ///find value if column matches any value defnied in formula json
            foreach (var jsonnode in formulaJson.Root)
            {
                List<string> temp = ((JArray)formulaJson[((JProperty)jsonnode).Name]).Select(f => f.ToString()).ToList();
                if ((from val in temp
                     where val.Contains(columnName.ToLower())
                     select val).Any())
                {
                    formulaNodeName = ((JProperty)jsonnode).Name;
                    break;
                }
            }
            if (!string.IsNullOrEmpty(formulaNodeName))
            {
                ///if passed column as defined mapped column values thrn apply the for formula 
                ///As in case of name like mapping firstname,lastname is concetenating 
                if (formulaNodeName == FormulaFields.name.ToString())
                {
                    Firstname=  ((JArray)FileDataObj["firstname"]).Select(f => f.ToString()).ToList();
                    LastNames = ((JArray)FileDataObj["lastname"]).Select(f => f.ToString()).ToList();
                    DataList = Firstname.Join(LastNames, s => Firstname.IndexOf(s), i => LastNames.IndexOf(i), (s, i) => new { sv = s, iv = i }).Select(e => e.sv+" " + e.iv).ToList();
                }
            }
            else
            {
                ///if exact match of passed column name is not found , then find match names 
                if (matchValue.Count == 0)
                {
                    matchValue = (from val in Nodes
                                  where val.Contains(columnName.ToLower())
                                  select val).ToList();
                }
                if (matchValue.Count != 0)
                {
                    var data = ((JArray)FileDataObj[matchValue.First()]);
                    if (data != null)
                    {
                        DataList = data.Select(f => f.ToString()).ToList();
                    }
                }
            }
            return DataList;

        }

        /// <summary>
        /// read the node of json and creating a list of node 
        /// </summary>
        /// <param name="jobject"></param>
        /// <returns></returns>
        public List<string> ReadNode(JObject jobject)
        {
            List<string> Nodes = new List<string>();

            foreach (var jsonnode in jobject.Root)
            {
                Nodes.Add(((JProperty)jsonnode).Name);
            }
            return Nodes;
        }

      
    }
}
