using ClosedXML.Excel;
using System;
using System.Data;


namespace Common.FileProcessing
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
