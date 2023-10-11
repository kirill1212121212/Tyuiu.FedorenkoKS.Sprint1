using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FedorenkoKS.Sprint1.Task1.V14.Lib;

namespace Tyuiu.FedorenkoKS.Sprint1.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 15.0;
            double b = 2.0;
            double c = 3.0;
            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(13, res);
        }
    }
}
