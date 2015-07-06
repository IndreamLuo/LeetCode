using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Code;

namespace LeetCode.Test
{
    [TestClass]
    public class RemoveDuplicatesFromSortedArrayTest
    {
        RemoveDuplicatesFromSortedArray removeDuplicatesFromSortedArray = new RemoveDuplicatesFromSortedArray();

        [TestMethod]
        public void RemoveDuplicates()
        {
            var array = new int[] { 1, 1, 2 };
            var result = removeDuplicatesFromSortedArray.RemoveDuplicates(array);
            Assert.AreEqual(2, result);
            Assert.AreEqual(1, array[0]);
            Assert.AreEqual(2, array[1]);

            Assert.AreEqual(0, removeDuplicatesFromSortedArray.RemoveDuplicates(new int[] { }));
            Assert.AreEqual(1, removeDuplicatesFromSortedArray.RemoveDuplicates(new int[] { 1 }));
        }
    }
}
