using BusinessLayer.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FileProcessing
{
    public class CsvExport : IExport
    {
        public void CreateFile(DataTable data, string fileName, char delimiter = ',', bool generateHeader = true)
        {
            data.ToCSVOrTextFile(fileName, delimiter, generateHeader);
        }
    }
}
