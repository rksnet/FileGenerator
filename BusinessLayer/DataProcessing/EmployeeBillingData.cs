using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataProcessing
{
    public class EmployeeBillingData
    {
        public EmployeeBillingData()
        {
        }

        public string EmployeeID
        {
            get;
            set;
        }
        public string EmployeeName
        {
            get;
            set;
        }
        public string Currency
        {
            get;
            set;
        }
        public int? RateSet
        {
            get;
            set;
        }
        public int? InpuFile1_Hour
        {
            get;
            set;
        }
        public Nullable<int> InpuFile2_Hour
        {
            get;
            set;
        }
        public int? Total
        {
            get;
            set;
        }
        public string Month
        {
            get;
            set;
        }
        public string Match
        {
            get;
            set;
        }
        public int Difference
        {
            get;
            set;
        }
        public string Reason
        {
            get;
            set;
        }
        public string  File2EmployeeID
        {
            get;
            set;
        }
    }
}
