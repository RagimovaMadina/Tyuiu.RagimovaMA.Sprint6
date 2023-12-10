using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.RagimovaMA.Sprint6.Task6.V28.Lib;

namespace Tyuiu.RagimovaMA.Sprint6.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V28.txt";
            string wait = "wFrlYaZtHI l eAezSXF eqSGAiC wUdVEuNB";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckFile()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V28.txt";
            FileInfo file = new FileInfo(path);
            bool exists = file.Exists;
            Assert.AreEqual(true, exists);
        }
    }
}