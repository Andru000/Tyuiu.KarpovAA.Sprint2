using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint2.Task4.V28.Lib;

namespace Tyuiu.KarpovAA.Sprint2.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 10;
            double res = ds.Calculate(x,y);
            double wait = 13;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 17.452;
            Assert.AreEqual(wait, res);
        }

    }
}
