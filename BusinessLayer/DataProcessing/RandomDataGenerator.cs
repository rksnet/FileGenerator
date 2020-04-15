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
        public readonly int totalRecordCount = 0;
        #endregion

        #region Constructor              

        public RandomDataGenerator(int recordCount)
        {
            totalRecordCount = recordCount;
        }
        #endregion

        #region Get random data by passing column details

        private DataTable GetRandamData(ColumnXmlDefination.Columns columnList)
        {
            List<Tuple<List<Object>, string, Type>> Data = new List<Tuple<List<Object>, string, Type>>();
            foreach (var column in columnList.Column)
            {
                Data.Add(GenerateRandamData(column));
            }
            return ListToDatatable(Data);
        }

        private Tuple<List<Object>, string, Type> GenerateRandamData(ColumnXmlDefination.Column column)
        {
            Tuple<List<Object>, string, Type> RandomData = Tuple.Create(new List<object>(), string.Empty, typeof(int));
            try
            {
                switch (column.Datatype.ToLower())
                {
                    case "string":
                        RandomData = Tuple.Create(RandomString(column).Cast<object>().ToList(), column.Name, typeof(string));
                        break;
                    case "int":
                        RandomData = Tuple.Create(RandomInteger(column).Cast<object>().ToList(), column.Name, typeof(int));
                        break;
                    case "decimal":
                        RandomData = Tuple.Create(RandomDouble(column).Cast<object>().ToList(), column.Name, typeof(decimal));
                        break;
                    case "double":
                        RandomData = Tuple.Create(RandomDouble(column).Cast<object>().ToList(), column.Name, typeof(double));
                        break;
                    case "date":
                        RandomData = Tuple.Create(RandomDate(column).Cast<object>().ToList(), column.Name, typeof(DateTime));
                        break;
                }

            }
            catch (Exception)
            {
                //log error
            }
            return RandomData;
        }

        #endregion

        #region Random data generator methods             

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
                    int ranInt = random.Next();
                    lstInt.Add(ranInt);
                }
                // generate the negative data for specified no of negative record in xml
                for (int i = 0; i < negativeRecordCnt; i++)
                {
                    int ranInt = random.Next() * -1;
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

        private List<string> RandomString(ColumnXmlDefination.Column column)
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
                    StringBuilder builder = new StringBuilder();
                    char ch;
                    for (int j = 0; j < maxlength; j++)
                    {
                        ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                        builder.Append(ch);
                    }
                    lstString.Add(builder.ToString());
                }
                // generate the string which is greater than the maximum length for specified no of negative record in xml
                for (int i = 0; i < negativeRecordCnt; i++)
                {
                    StringBuilder builder = new StringBuilder();
                    char ch;
                    for (int j = 0; j < maxlength + 10; j++)// 10 defined to increase  the maximum string length
                    {
                        ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                        builder.Append(ch);
                    }
                    lstString.Add(builder.ToString());
                }

            }
            catch (Exception)
            {
                //log error
            }
            return lstString;

        }

        private List<DateTime> RandomDate(ColumnXmlDefination.Column column)
        {
            Random random = new Random();
            List<DateTime> lstDate = new List<DateTime>();

            DateTime startDate = column.StartDate != DateTime.MinValue || column.StartDate != null ? Convert.ToDateTime(column.StartDate) : DateTime.Today;
            DateTime maxDate = column.EndDate != DateTime.MinValue || column.EndDate != null  ? Convert.ToDateTime(column.EndDate) : startDate.AddYears(40);
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

        private int RandomIneger(int min, int max)
        {

            Random random = new Random();
            return random.Next(min, max);
        }

        private string RandomString(int size, bool lowerCase)
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
        private string FirstName()
        {
            Random rnd = new Random();
            string[] firtsName = { "Rufus", "Bear", "Dakota", "Fido",
                          "Vanya", "Samuel", "Koani", "Volodya",
                          "Prince", "Yiska" };

            int index = rnd.Next(firtsName.Length);
            return firtsName[index];
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


            #endregion

        }
    }
}
