using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FedorenkoKS.Sprint1.Task2.V10.Lib;

namespace Tyuiu.FedorenkoKS.Sprint1.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            var res = ds.ConvertMetreToInchs(x);
            Assert.AreEqual(39.37008, res);
        }
    }
}
