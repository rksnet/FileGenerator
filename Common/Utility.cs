using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Common
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
        /// <summary>
        /// this will convert datatable to flat file 
        /// </summary>
        /// <param name="dtDataTable"></param>
        /// <param name="strFilePath"></param>
        /// <param name="separator"></param>
        public static void FlatFileGenerator(this DataTable dtDataTable, string strFilePath = @"C:\Users\rohit\source\repos\rksnet\FileGenerator\FileGeneratorApp\test.csv", char separator = ',')
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            //headers  
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                sw.Write(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(separator.ToString());
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(separator))
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
                        sw.Write(separator.ToString());
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }

    }
}
