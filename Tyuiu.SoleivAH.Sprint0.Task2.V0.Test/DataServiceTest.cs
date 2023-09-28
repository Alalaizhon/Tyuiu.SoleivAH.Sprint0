using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SoleivAH.Sprint0.Task2.V0.Lib;
namespace Tyuiu.SoleivAH.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Алишка";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Алишка", res);
        }
    }
}
