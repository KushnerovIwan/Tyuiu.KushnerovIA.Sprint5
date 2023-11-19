using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KushnerovIA.Sprint5.Task1.V6.Lib;

using System.IO;
namespace Tyuiu.KushnerovIA.Sprint5.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\kia45\source\repos\Tyuiu.KushnerovIA.Sprint5\Tyuiu.KushnerovIA.Sprint5.Task1.V6\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}