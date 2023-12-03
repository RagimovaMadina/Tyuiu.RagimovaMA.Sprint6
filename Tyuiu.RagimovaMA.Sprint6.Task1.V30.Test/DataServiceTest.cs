using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RagimovaMA.Sprint6.Task1.V30.Lib;

namespace Tyuiu.RagimovaMA.Sprint6.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            int len = stop - start + 1;
            double[] wait = new double[len];
            wait[0] = -32.26;
            wait[1] = -27.50;
            wait[2] = -22.80;
            wait[3] = -17.95;
            wait[4] = -12.97;
            wait[5] = -9;
            wait[6] = -0.31;
            wait[7] = 3.77;
            wait[8] = 8.57;
            wait[9] = 13.42;
            wait[10] = 18.28;

            double[] res = new double[len];
            res = ds.GetMassFunction(start, stop);
        }
    }
}
