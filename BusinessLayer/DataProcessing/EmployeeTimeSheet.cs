using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using LinqToExcel;
using ClosedXML.Excel;


namespace BusinessLayer.DataProcessing
{
    public class EmployeeTimeSheet
    {

        #region Constructor                      

        public EmployeeTimeSheet()
        {
        }

        #endregion

        #region Read Data from Excel and Write compare data in excel

        #region  GetEmpBillingCompOutputFile          
        public string GetEmpBillingCompOutputFile(string input_File1,
                                    string input_File2, string outputFilePath)
        {

            string fileExportStatus = string.Empty;
            try
            {
                List<EmployeeBillingData> lstBillCompData = new List<EmployeeBillingData>();
                lstBillCompData = GetEmpBillingCompareData(input_File1, input_File2);

                if (lstBillCompData.Count > 0)
                {
                    fileExportStatus = ExportListDataToExcel(lstBillCompData, outputFilePath);
                }
                else
                {
                    throw new Exception("No Data Found in Excel or Excell Read error.Please Contact Administrator");
                }
            }
            catch (Exception ex)
            {
                // log error
            }
            return fileExportStatus;
        }

        #endregion

        #region GetEmpBillingCompareData               
        private List<EmployeeBillingData> GetEmpBillingCompareData(string input_File1,
                                    string input_File2)
        {

            List<EmployeeBillingData> lstBillCompData = new List<EmployeeBillingData>();
            List<EmployeeBillingData> lstLeftOuter = new List<EmployeeBillingData>();
            List<EmployeeBillingData> lstRightOuter = new List<EmployeeBillingData>();

            List<InputFile1> lstInput1 = new List<InputFile1>();
            List<InputFile2> lstInput2 = new List<InputFile2>();
            try
            {

                var book = new LinqToExcel.ExcelQueryFactory(input_File1);
                var input1 =
                    from row in book.Worksheet(0)
                    let item = new InputFile1
                    {
                        EmployeeID = row["Employee"].Cast<string>(),
                        EmployeeName = row["EmployeeName"].Cast<string>(),
                        Currency = row["Currency"].Cast<string>(),
                        Hour = row["Hour"].Cast<string>(),
                        RateSet = row["RateSet"].Cast<string>(),
                        Total = "",
                        Month = row["Month"].Cast<string>(),
                    }
                    select item;

                lstInput1 = input1.ToList<InputFile1>();


                var file2 = new LinqToExcel.ExcelQueryFactory(input_File2);
                var input2 =
                    from row in file2.Worksheet(0)
                    let item2 = new InputFile2
                    {
                        EmployeeID = row["Employee"].Cast<string>(),
                        EmployeeName = row["EmployeeName"].Cast<string>(),
                        Hour = row["Hour"].Cast<string>(),

                    }
                    select item2;

                lstInput2 = input2.ToList<InputFile2>();

                //Input sheet1 Match with Input2------------------

                var finalResult = from f1 in lstInput1
                                  join f2 in lstInput2 on f1.EmployeeID equals f2.EmployeeID
                                  select new EmployeeBillingData
                                  {
                                      EmployeeID = f1.EmployeeID,
                                      EmployeeName = f1.EmployeeName,
                                      Currency = f1.Currency,
                                      RateSet = Convert.ToInt32(f1.RateSet),
                                      InpuFile1_Hour = Convert.ToInt32(f1.Hour),
                                      InpuFile2_Hour = Convert.ToInt32(f1.Hour),
                                      Total = Convert.ToInt32(f1.RateSet) * Convert.ToInt32(f1.Hour),
                                      Month = f1.Month,
                                      Match = f1.Hour == f2.Hour ? "True" : "False",
                                      Difference = Convert.ToInt32(f2.Hour) - Convert.ToInt32(f1.Hour),
                                      Reason = "Data available in Both File"
                                  };

                lstBillCompData = finalResult.ToList<EmployeeBillingData>();

                //Left outer join Input sheet1 not Match with Input2
                var finalLeftOuterJoin = from f1 in lstInput1
                                         join f2 in lstInput2 on f1.EmployeeID equals f2.EmployeeID
                                         into f1Andf2Group
                                         from outerResult in f1Andf2Group.DefaultIfEmpty()
                                         select new EmployeeBillingData
                                         {
                                             EmployeeID = f1.EmployeeID,
                                             EmployeeName = f1.EmployeeName,
                                             Currency = f1.Currency,
                                             RateSet = Convert.ToInt32(f1.RateSet),
                                             InpuFile1_Hour = Convert.ToInt32(f1.Hour),
                                             InpuFile2_Hour = 0,
                                             Total = Convert.ToInt32(f1.RateSet) * Convert.ToInt32(f1.Hour),
                                             Month = f1.Month,
                                             Match = "False",
                                             File2EmployeeID = outerResult == null ? "No Employee" : outerResult.EmployeeID,
                                             Difference = Convert.ToInt32(f1.Hour),
                                             Reason = "Data Not available in input2 file"
                                         };

                lstLeftOuter = finalLeftOuterJoin.ToList<EmployeeBillingData>();
                lstBillCompData.AddRange(lstLeftOuter.Where(e => e.File2EmployeeID == "No Employee"));

                //right outer join Input sheet1 not Match with Input2-
                var finalRightOuterJoin = from f2 in lstInput2
                                          join f1 in lstInput1 on f2.EmployeeID equals f1.EmployeeID
                                          into Inpu2AndInput1Group
                                          from outerResult in Inpu2AndInput1Group.DefaultIfEmpty()
                                          select new EmployeeBillingData
                                          {
                                              EmployeeID = f2.EmployeeID,
                                              EmployeeName = f2.EmployeeName,
                                              Currency = outerResult == null ? "" : outerResult.Currency,
                                              RateSet = outerResult == null ? 0 : Convert.ToInt32(outerResult.RateSet),
                                              InpuFile1_Hour = outerResult == null ? 0 : Convert.ToInt32(outerResult.Hour),
                                              InpuFile2_Hour = Convert.ToInt32(f2.Hour),
                                              Total = outerResult == null ? 0 : Convert.ToInt32(outerResult.RateSet) * Convert.ToInt32(outerResult.Hour),
                                              Month = outerResult == null ? "" : outerResult.Month,
                                              Match = "False",
                                              File2EmployeeID = outerResult == null ? "No Employee" : outerResult.EmployeeID,
                                              Difference = Convert.ToInt32(f2.Hour) * 1,
                                              Reason = "Data Not available in input1 file"
                                          };

                lstRightOuter = finalRightOuterJoin.ToList<EmployeeBillingData>();
                lstBillCompData.AddRange(lstRightOuter.Where(e => e.File2EmployeeID == "No Employee"));


            }
            catch (Exception ex)
            {
                //log error
            }
            return lstBillCompData;
        }

        #endregion

        #region Write the data in excel file            

        public string ExportListDataToExcel(List<EmployeeBillingData> lstBillCompData, string outputFilePath)
        {
            string fileExportStatus = string.Empty;
            outputFilePath = string.Format("{0}.{1}", outputFilePath, "xlsx");
            try
            {
                //lstBillCompData=lstBillCompData.

                var lstCompData = lstBillCompData.Select(x => new
                {
                    x.EmployeeID,
                    x.EmployeeName,
                    x.Currency,
                    x.RateSet,
                    x.InpuFile1_Hour,
                    x.InpuFile2_Hour,
                    x.Total,
                    x.Month,
                    x.Match,
                    x.Difference,
                    x.Reason
                }).ToList();

                List<string[]> titles = new List<string[]> { new string[] { "Employee ID", "Employee Name", "Currency", "RateSet", "InpuFile1_Hour", "InpuFile2_Hour", "Total", "Month", "Match", "Difference", "Reason" } };
                var wb = new XLWorkbook(); //create workbook
                var ws = wb.Worksheets.Add("OutPut"); //add worksheet to workbook
                var rangeTitle = ws.Cell(1, 1).InsertData(titles); //insert titles to first row
                rangeTitle.AddToNamed("Titles");
                var titlesStyle = wb.Style;
                titlesStyle.Font.Bold = true; //font must be bold
                titlesStyle.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; //align text to center
                titlesStyle.Fill.BackgroundColor = XLColor.Yellow;
                titlesStyle.Border.OutsideBorder = XLBorderStyleValues.Thick;
                titlesStyle.Border.OutsideBorderColor = XLColor.Black;
                wb.NamedRanges.NamedRange("Titles").Ranges.Style = titlesStyle; //attach

                if (lstBillCompData != null && lstBillCompData.Count() > 0)
                {
                    //insert data 
                    ws.Cell(2, 1).InsertData(lstCompData);
                    ws.Columns().AdjustToContents();

                }

                wb.SaveAs(outputFilePath);

            }
            catch (Exception ex)
            {
                fileExportStatus = ex.Message.ToString();
            }
            return fileExportStatus;
        }

        #endregion


        #endregion
    }
}
