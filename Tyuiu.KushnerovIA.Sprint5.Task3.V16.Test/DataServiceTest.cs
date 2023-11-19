using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KushnerovIA.Sprint5.Task3.V16.Lib;

namespace Tyuiu.KushnerovIA.Sprint5.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\kia45\source\repos\Tyuiu.KushnerovIA.Sprint5\Tyuiu.KushnerovIA.Sprint5.Task3.V16\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}