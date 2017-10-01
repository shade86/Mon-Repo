using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mon_Repo;

namespace Mon_RepoTests
{
    [TestClass]
    public class StatisticsTests
    {
        [TestMethod]
        public void QuantityTest()
        {
            var sum = Statistics.SumQuantity(
                new Product[0]
                );
            Assert.AreEqual(0, sum);
        }
        [TestMethod]
        public void SumSpentTest()
        {
            var sum = Statistics.SumSpent(
                new[]
                {
                new Product { Quantity = 30, Price = 100 }
                });
            Assert.AreEqual(3000, sum);
        }
    }
}
