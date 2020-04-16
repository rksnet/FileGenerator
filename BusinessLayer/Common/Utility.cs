using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Xml.Serialization;


namespace BusinessLayer.Common
{
    public static class Utility
    {
        /// <summary>
        /// Generic method to Deserialize any xml string to object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static T DeserializeFromXml<T>(string xml)
        {
            if (string.IsNullOrEmpty(xml))
                return default(T);
            T result;
            var ser = new XmlSerializer(typeof(T));
            using (var tr = new StringReader(xml))
            {
                result = (T)ser.Deserialize(tr);
            }
            return result;
        }
        public static void ToCSVOrTextFile(this DataTable dtDataTable, string strFilePath = @"C:\Users\rohit\source\repos\rksnet\FileGenerator\FileGeneratorApp\test.csv", char delimiter = ',', bool generateHeader = true)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            if (generateHeader)
            {
                //headers  
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    sw.Write(dtDataTable.Columns[i]);
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(delimiter);
                    }
                }
                sw.Write(sw.NewLine);
            }
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(delimiter);
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }

    }
}
