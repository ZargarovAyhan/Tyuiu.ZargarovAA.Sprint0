using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZargarovAA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ZargarovAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Айхан";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Айхан", res);
        }
    }
}
