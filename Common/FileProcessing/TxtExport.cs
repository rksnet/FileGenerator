
using System.Data;



namespace Common.FileProcessing
{
    public class TxtExport : IExport
    {
        public void CreateFile(DataTable data, string fileName, char delimiter = ',', bool generateHeader = true)
        {
            data.FlatFileGenerator(fileName, delimiter);
        }
    }
}
