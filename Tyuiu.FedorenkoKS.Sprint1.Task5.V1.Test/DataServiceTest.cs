using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FedorenkoKS.Sprint1.Task5.V1.Lib;

namespace Tyuiu.FedorenkoKS.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x1 = 5;
            double x2 = 2;
            double y1 = 8;
            double y2 = 4;
            DataService ds = new DataService();
            double res = ds.DistanceBetweenDots( x1,  y1,  x2,  y2);

            int result = Convert.ToInt32(res);
            int wait = 5;
            Assert.AreEqual(wait, result);
        }
    }
}
