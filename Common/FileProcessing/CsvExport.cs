
using System.Data;


namespace Common.FileProcessing
{
    public class CsvExport : IExport
    {
        public void CreateFile(DataTable data, string fileName, char delimiter = ',', bool generateHeader = true)
        {
            data.FlatFileGenerator(fileName, delimiter);
        }
    }
}
