using BusinessLayer.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BusinessLayer.XMLMapping.ConcreteXmlClass;

namespace BusinessLayer.DataProcessing
{
   public static class Mapper
    {
        public static void GetFileStructure (string xml)
        {
            FileGenerator objFileGenerator = Utility.DeserializeFromXml<FileGenerator>(xml);
            RandomDataGenerator objRandomDataGenerator = new RandomDataGenerator(objFileGenerator.FooterDetails.RecordCount.Value);
            ToCSV(objRandomDataGenerator.GetRandamData(objFileGenerator.Columns));
        }
        public  static void ToCSV(this DataTable dtDataTable, string strFilePath= @"C:\Users\rohit\source\repos\rksnet\FileGenerator\FileGeneratorApp\")
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            //headers  
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                sw.Write(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(",");
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
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }
    }
}
