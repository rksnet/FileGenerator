using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FileProcessing
{
    public class ExportFactory
    {
        public enum ExportFileType
        {
            Csv,
            Excel,
            Txt
        }
        public IExport GetFileType(ExportFileType fileType)
        {
            switch (fileType)
            {
                case ExportFileType.Csv:
                    return new CsvExport();
                case ExportFileType.Excel:
                    return new ExcelExport();
                case ExportFileType.Txt:
                    return new TxtExport();
                default:
                    throw new ApplicationException(string.Format(" FileType  '{0}' cannot be created.", fileType));
            }
        }
    }
}
