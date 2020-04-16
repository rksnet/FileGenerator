using BusinessLayer.Common;
using BusinessLayer.XMLMapping;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer.DataProcessing
{
    /// <summary>
    /// Mapper class to perform addtionional functionlity over the xml data other than column generation 
    /// </summary>
    public class Mapper
    {
        /// <summary>
        /// process xml data and generates the flat file 
        /// </summary>
        /// <param name="xmlFilePath"></param>
        /// <param name="saveFilePath"></param>
        public void GetTestFile(string xmlFilePath, string saveFilePath)
        {
            FileGenerator objFileGenerator = Utility.DeserializeFromXml<FileGenerator>(xmlFilePath);
            RandomDataGenerator objRandomDataGenerator = new RandomDataGenerator(objFileGenerator.FooterDetails.RecordCount.Value);
            var dataTable = objRandomDataGenerator.GetRandamData(objFileGenerator.Columns);
            Utility.FlatFileGenerator(dataTable, saveFilePath, DataTypeHandler.lstCharType.Contains(objFileGenerator.CommonDetails.Separater) == true ? Convert.ToChar(objFileGenerator.CommonDetails.Separater) : ',');
        }

    }
}
