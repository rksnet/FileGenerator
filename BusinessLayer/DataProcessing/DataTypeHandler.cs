using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataProcessing
{
    public static class DataTypeHandler
    {

        private static List<T> CreateList<T>(params T[] elements)
        {
            return new List<T>(elements);
        }

        public static List<string> lstStringType = new List<string>(CreateList<String>("string", "varchar", "nvarchar"));
        public static List<string> lstIntType = new List<string>(CreateList<String>("int", "integer", "number", "num"));
        public static List<string> lstDecimalType = new List<string>(CreateList<String>("decimal", "double", "float"));
        public static List<string> lstDateType = new List<string>(CreateList<String>("date", "datetime"));
    }
}
