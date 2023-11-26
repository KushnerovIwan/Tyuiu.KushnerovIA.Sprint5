using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KushnerovIA.Sprint5.Task4.V18.Lib;

namespace Tyuiu.KushnerovIA.Sprint5.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V18.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileex = fileinfo.Exists;
            Assert.AreEqual(true, fileex);
        }
    }
}