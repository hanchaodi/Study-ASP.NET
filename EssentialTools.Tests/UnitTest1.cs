using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTools.Models;
namespace EssentialTools.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Discount_Above_100()
        {
            IDiscountHelper target = getTestObject();
            decimal total = 200;

            var discountedTotal = target.ApplyDiscount(total);

            Assert.AreEqual(total * 0.9m, discountedTotal);
        }

        private IDiscountHelper getTestObject()
        {
            return new MinimumDiscountHelper();
        }

        [TestMethod]
        public void Discount_Between_10_And_100()
        {

        }

    }
}
