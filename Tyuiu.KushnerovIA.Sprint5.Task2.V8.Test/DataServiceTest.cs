using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KushnerovIA.Sprint5.Task2.V8.Lib;

namespace Tyuiu.KushnerovIA.Sprint5.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\kia45\source\repos\Tyuiu.KushnerovIA.Sprint5\Tyuiu.KushnerovIA.Sprint5.Task2.V8\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
