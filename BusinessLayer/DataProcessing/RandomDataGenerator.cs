using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.XMLMapping;

namespace BusinessLayer.DataProcessing
{
    public class RandomDataGenerator
    {
        #region Variables            
        private readonly int totalRecordCount = 0;
        #endregion

        #region Constructor              

        public RandomDataGenerator(int recordCount)
        {
            totalRecordCount = recordCount;
        }
        #endregion

        #region Get random data by passing column details
        /// <summary>
        /// Genrates hr random data and write it datatable 
        /// </summary>
        /// <param name="columnList"></param>
        /// <returns></returns>
        public DataTable GetRandamData(ColumnXmlDefination.Columns columnList)
        {
            List<Tuple<List<Object>, string, Type>> Data = new List<Tuple<List<Object>, string, Type>>();
            foreach (var column in columnList.Column)
            {
                Data.Add(GenerateRandamData(column));
            }
            return ListToDatatable(Data);
        }

        /// <summary>
        /// Creates based on column's datatype
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        private Tuple<List<Object>, string, Type> GenerateRandamData(ColumnXmlDefination.Column column)
        {
            Tuple<List<Object>, string, Type> RandomData = Tuple.Create(new List<object>(), string.Empty, typeof(int));
            try
            {
                if (DataTypeHandler.lstStringType.Contains(column.Datatype.ToLower()))
                {
                    RandomData = Tuple.Create(RandomStringList(column).Cast<object>().ToList(), column.Name, typeof(string));
                }
                else if (DataTypeHandler.lstIntType.Contains(column.Datatype.ToLower()))
                {
                    RandomData = Tuple.Create(RandomInteger(column).Cast<object>().ToList(), column.Name, typeof(int));
                }
                else if (DataTypeHandler.lstDecimalType.Contains(column.Datatype.ToLower()))
                {
                    RandomData = Tuple.Create(RandomDouble(column).Cast<object>().ToList(), column.Name, typeof(decimal));
                }
                else if (DataTypeHandler.lstDateType.Contains(column.Datatype.ToLower()))
                {
                    RandomData = Tuple.Create(RandomDate(column).Cast<object>().ToList(), column.Name, typeof(DateTime));
                }
                else
                { RandomData = Tuple.Create(DataTypeMismatchList(column).Cast<object>().ToList(), column.Name, typeof(string)); }

            }
            catch (Exception)
            {
                //log error
            }
            return RandomData;
        }

        #endregion

        #region Random data generator methods             

        /// <summary>
        /// Generates random string also verifies the column attribute .
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        private List<string> RandomStringList(ColumnXmlDefination.Column column)
        {
            Random random = new Random();
            List<string> lstString = new List<string>();
            int negativeRecordCnt = 0;
            int maxlength = column.Length != 0 ? Convert.ToInt32(column.Length) : 100;
            int.TryParse(Convert.ToString(column.NegativeValue), out negativeRecordCnt);
            int recordCount = totalRecordCount - negativeRecordCnt <= 0 ? totalRecordCount : totalRecordCount - negativeRecordCnt;
            try
            {
                // generate the maximum length of string
                for (int i = 0; i < recordCount; i++)
                {
                    lstString.Add(RandomString(maxlength));
                }
                // generate the string which is greater than the maximum length for specified no of negative record in xml
                for (int i = 0; i < negativeRecordCnt; i++)
                {
                    lstString.Add(RandomString(maxlength + 10));
                }
            }
            catch (Exception)
            {
                //log error
            }
            return lstString;

        }
        private List<int> RandomInteger(ColumnXmlDefination.Column column)
        {
            Random random = new Random();
            List<int> lstInt = new List<int>();
            int negativeRecordCnt = 0;
            int.TryParse(Convert.ToString(column.NegativeValue), out negativeRecordCnt);
            int recordCount = totalRecordCount - negativeRecordCnt <= 0 ? totalRecordCount : totalRecordCount - negativeRecordCnt;
            try
            {
                // generate the possitive data 
                for (int i = 0; i < recordCount; i++)
                {
                    int ranInt = random.Next(column.MinLength, column.MaxLength == 0 ? 1000 : column.MaxLength);
                    lstInt.Add(ranInt);
                }
                // generate the negative data for specified no of negative record in xml
                for (int i = 0; i < negativeRecordCnt; i++)
                {
                    int ranInt = random.Next(column.MinLength == 0 ? -10 : column.MinLength - 10, column.MaxLength == 0 ? 1000 + 100 : column.MaxLength + 100) * -1;
                    lstInt.Add(ranInt);
                }

            }
            catch (Exception)
            {
                //log error
            }
            return lstInt;

        }
        private List<double> RandomDouble(ColumnXmlDefination.Column column)
        {
            Random random = new Random();
            List<double> lstDouble = new List<double>();
            int negativeRecordCnt = 0;
            int.TryParse(Convert.ToString(column.NegativeValue), out negativeRecordCnt);
            int recordCount = totalRecordCount - negativeRecordCnt <= 0 ? totalRecordCount : totalRecordCount - negativeRecordCnt;
            try
            {
                // generate the possitive data 
                for (int i = 0; i < recordCount; i++)
                {
                    double ranDouble = Convert.ToDouble(random.Next() * random.NextDouble());
                    lstDouble.Add(ranDouble);
                }
                // generate the negative data for specified no of negative record in xml
                for (int i = 0; i < negativeRecordCnt; i++)
                {
                    double ranDouble = Convert.ToDouble(random.Next() * -random.NextDouble());
                    lstDouble.Add(ranDouble);
                }

            }
            catch (Exception)
            {
                //log error
            }
            return lstDouble;

        }
        /// <summary>
        /// Generates randon string based on column defination and attributes
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>

        private List<DateTime> RandomDate(ColumnXmlDefination.Column column)
        {
            Random random = new Random();
            List<DateTime> lstDate = new List<DateTime>();

            DateTime startDate = column.StartDate != DateTime.MinValue || column.StartDate != null ? Convert.ToDateTime(column.StartDate) : DateTime.Today;
            DateTime maxDate = column.EndDate != DateTime.MinValue || column.EndDate != null ? Convert.ToDateTime(column.EndDate) : startDate.AddYears(40);
            int negativeRecordCnt = 0;
            int.TryParse(Convert.ToString(column.NegativeValue), out negativeRecordCnt);
            int recordCount = totalRecordCount - negativeRecordCnt <= 0 ? totalRecordCount : totalRecordCount - negativeRecordCnt;
            try
            {

                if (recordCount > 0)// generate the possitive data 
                {
                    var randomResult = GetRandomNumbers(recordCount).ToArray();
                    var calculationValue = maxDate.Subtract(startDate).TotalMinutes / int.MaxValue;
                    var dateResults = randomResult.Select(s => startDate.AddMinutes(s * calculationValue)).ToList();
                    lstDate = dateResults;
                }
                if (negativeRecordCnt > 0) // generate the negative data for specified no of negative record in xml
                {
                    maxDate = startDate; startDate = startDate.AddYears(-40);
                    var randomResult = GetRandomNumbers(negativeRecordCnt).ToArray();

                    var calculationValue = maxDate.Subtract(startDate).TotalMinutes / int.MaxValue;
                    var dateResults = randomResult.Select(s => startDate.AddMinutes(s * calculationValue)).ToList();
                    if (lstDate != null)
                    {
                        foreach (var value in dateResults)
                        {
                            lstDate.Add(value);
                        }

                    }
                    else
                    {
                        lstDate = dateResults;
                    }
                }



            }
            catch (Exception)
            {
                //log error
            }
            return lstDate;

        }
        private string RandomString(int size, bool lowerCase = false)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        public static IEnumerable<int> GetRandomNumbers(int size)
        {
            var data = new byte[4];
            using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider(data))
            {
                for (int i = 0; i < size; i++)
                {
                    rng.GetBytes(data);

                    var value = BitConverter.ToInt32(data, 0);
                    yield return value < 0 ? value * -1 : value;
                }
            }
        }
        /// <summary>
        /// This method will execute in case datatype defination not found in the application 
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        private List<string> DataTypeMismatchList(ColumnXmlDefination.Column column)
        {
            List<string> lstString = new List<string>();
            try
            {
                for (int i = 0; i < totalRecordCount; i++)
                {
                    lstString.Add("Data type mismatch");
                }
            }
            catch (Exception)
            {
                //log error
            }
            return lstString;

        }

        #endregion

        #region Data Processing
        public static DataTable ListToDatatable(List<Tuple<List<Object>, string, Type>> data)
        {
            DataTable dt = new DataTable();

            foreach (var item in data)
            {
                dt.Columns.Add(item.Item2, item.Item3);
            }

            for (int i = 0; i < data[0].Item1.Count; i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < data.Count; j++)
                {
                    if (data[j].Item1.ElementAtOrDefault(i) != null)
                    {
                        dr[j] = data[j].Item1[i];
                    }
                }
                dt.Rows.Add(dr);
            }
            return dt;




        }
        #endregion
    }
}
