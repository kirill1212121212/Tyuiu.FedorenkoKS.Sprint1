using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FedorenkoKS.Sprint1.Task4.V7.Lib;

namespace Tyuiu.FedorenkoKS.Sprint1.Task4.V7.Test

{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 1;
            double wait = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res); 
        }
    }
}
