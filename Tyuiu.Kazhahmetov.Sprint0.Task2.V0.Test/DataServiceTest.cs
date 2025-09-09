using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Kazhahmetov.Sprint0.Task2.V0.Lib;

namespace Tyuiu.Kazhahmetov.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Амир";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Амир", res);
        }
    }
}
