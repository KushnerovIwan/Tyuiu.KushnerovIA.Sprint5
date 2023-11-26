using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KushnerovIA.Sprint5.Task5.V16.Lib
{
    public class DataService : ISprint5Task5V16
    {
        public double LoadFromDataFile(string path)
        {

            StreamReader reader = new StreamReader(path);

            double res = -10000000000;
            string line;
            double x;
            while ((line = reader.ReadLine()) != null)
            {

                x = Convert.ToDouble(line);
                if (x % 10 == 0 && x > res && Convert.ToInt32(x) == Convert.ToDouble(x))
                {
                    res = x;

                }

            }
            return res;


        }
    }
}