using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using Common;
using BusinessLayer.XMLMapping;
using BusinessLayer.DataProcessing;
using System.Data;
using System.Xml;

namespace ApplicationUnitTest
{
    [TestClass]
    public class TestRandomMethods
    {
        [TestMethod]
        public void TestRandomInteger()
        {
            string xmlFilePath = @"C:\Reusable_Component\FileGenerator\rksnet\FileGenerator\FileGeneratorApp\ConfigFiles\XMLFIleInt.XML";
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFilePath);
            FileGenerator objFileGenerator = Utility.DeserializeFromXml<FileGenerator>(doc.InnerXml);
            RandomDataGenerator objRandomDataGenerator = new RandomDataGenerator(objFileGenerator.FooterDetails.RecordCount.Value);
            var dataTable = objRandomDataGenerator.GetRandamData(objFileGenerator.Columns);
            int result = 0;
            int negativeCount = 0;

            Assert.AreEqual(dataTable.Rows.Count, objFileGenerator.FooterDetails.RecordCount.Value);
            foreach(DataRow row in dataTable.Rows)
            {
                Assert.IsTrue(int.TryParse(row[0].ToString(), out result));
                if(row[0].ToString().Contains("-"))
                {
                    negativeCount++;
                }
            }
            Assert.AreEqual(negativeCount, objFileGenerator.Columns.Column[0].NegativeValue);
        }

        [TestMethod]
        public void TestRandomDouble()
        {
            string xmlFilePath = @"C:\Reusable_Component\FileGenerator\rksnet\FileGenerator\FileGeneratorApp\ConfigFiles\XMLFIleDouble.XML";
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFilePath);
            FileGenerator objFileGenerator = Utility.DeserializeFromXml<FileGenerator>(doc.InnerXml);
            RandomDataGenerator objRandomDataGenerator = new RandomDataGenerator(objFileGenerator.FooterDetails.RecordCount.Value);
            var dataTable = objRandomDataGenerator.GetRandamData(objFileGenerator.Columns);
            double result = 0;
            int negativeCount = 0;

            Assert.AreEqual(dataTable.Rows.Count, objFileGenerator.FooterDetails.RecordCount.Value);
            foreach (DataRow row in dataTable.Rows)
            {
                Assert.IsTrue(double.TryParse(row[0].ToString(), out result));
                if (row[0].ToString().Contains("-"))
                {
                    negativeCount++;
                }
            }
            Assert.AreEqual(negativeCount, objFileGenerator.Columns.Column[0].NegativeValue);
        }

        [TestMethod]
        public void TestRandomString()
        {
            string xmlFilePath = @"C:\Reusable_Component\FileGenerator\rksnet\FileGenerator\FileGeneratorApp\ConfigFiles\XMLFIleString.XML";
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFilePath);
            FileGenerator objFileGenerator = Utility.DeserializeFromXml<FileGenerator>(doc.InnerXml);
            RandomDataGenerator objRandomDataGenerator = new RandomDataGenerator(objFileGenerator.FooterDetails.RecordCount.Value);
            var dataTable = objRandomDataGenerator.GetRandamData(objFileGenerator.Columns);
            int negativeCount = 0;

            Assert.AreEqual(dataTable.Rows.Count, objFileGenerator.FooterDetails.RecordCount.Value);
            foreach (DataRow row in dataTable.Rows)
            {
                
                if (row[0].ToString().Length== (objFileGenerator.Columns.Column[0].Length +10))
                {
                    negativeCount++;
                }
                else
                    Assert.AreEqual(row[0].ToString().Length, objFileGenerator.Columns.Column[0].Length);
            }
            Assert.AreEqual(negativeCount, objFileGenerator.Columns.Column[0].NegativeValue);
        }

        [TestMethod]
        public void TestRandomDate()
        {
            string xmlFilePath = @"C:\Reusable_Component\FileGenerator\rksnet\FileGenerator\FileGeneratorApp\ConfigFiles\XMLFIleDate.XML";
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFilePath);
            FileGenerator objFileGenerator = Utility.DeserializeFromXml<FileGenerator>(doc.InnerXml);
            RandomDataGenerator objRandomDataGenerator = new RandomDataGenerator(objFileGenerator.FooterDetails.RecordCount.Value);
            var dataTable = objRandomDataGenerator.GetRandamData(objFileGenerator.Columns);
            int negativeCount = 0;

            Assert.AreEqual(dataTable.Rows.Count, objFileGenerator.FooterDetails.RecordCount.Value);
            foreach (DataRow row in dataTable.Rows)
            {

                if (row[0].ToString().Length == (objFileGenerator.Columns.Column[0].Length + 10))
                {
                    negativeCount++;
                }
                else
                    Assert.AreEqual(row[0].ToString().Length, objFileGenerator.Columns.Column[0].Length);
            }
            Assert.AreEqual(negativeCount, objFileGenerator.Columns.Column[0].NegativeValue);
        }

    }
}
