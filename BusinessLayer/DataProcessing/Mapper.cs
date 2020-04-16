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
   public  class Mapper
    {

        public  void GetFileStructure (string xml)
        {
            FileGenerator objFileGenerator = Utility.DeserializeFromXml<FileGenerator>(xml);
            RandomDataGenerator objRandomDataGenerator = new RandomDataGenerator(objFileGenerator.FooterDetails.RecordCount.Value);
            var dataTable=objRandomDataGenerator.GetRandamData(objFileGenerator.Columns);
        }

        public  void GetFile(string strFilePath)
        { 
        
        }
     
    }
}
