using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FileProcessing
{
    public interface IExport
    {
        void CreateFile(DataTable data, string fileName, char delimiter = ',', bool generateHeader = true);
    }
}
