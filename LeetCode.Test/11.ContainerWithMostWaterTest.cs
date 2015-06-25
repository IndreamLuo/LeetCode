using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Code;

namespace LeetCode.Test
{
    [TestClass]
    public class ContainerWithMostWaterTest
    {
        ContainerWithMostWater containerWithMostWater;

        public ContainerWithMostWaterTest()
        {
            this.containerWithMostWater = new ContainerWithMostWater();
        }

        [TestMethod]
        public void MaxArea()
        {
            var index = 0;
            Assert.AreEqual(this.containerWithMostWater.MaxArea(new int[15000].Select(item => ++index).ToArray()), 56250000);
            Assert.AreEqual(this.containerWithMostWater.MaxArea(new int[15000].Select(item => index--).ToArray()), 56250000);
            Assert.AreEqual(this.containerWithMostWater.MaxArea(new int[] { 2, 4, 6, 6, 4, 2 }), 12);
        }
    }
}
