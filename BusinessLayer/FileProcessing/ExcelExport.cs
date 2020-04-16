using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FileProcessing
{
    public class ExcelExport : IExport
    {
        public void CreateFile(DataTable data, string fileName, char delimiter = ',', bool generateHeader = true)
        {
            try
            {
                XLWorkbook wb = new XLWorkbook();
                wb.Worksheets.Add(data, "FileGenerator");
                wb.SaveAs(fileName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
