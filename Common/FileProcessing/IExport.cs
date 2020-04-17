
using System.Data;


namespace Common.FileProcessing
{
    public interface IExport
    {
        void CreateFile(DataTable data, string fileName, char delimiter = ',', bool generateHeader = true);
    }
}
