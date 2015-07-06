using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Code;

namespace LeetCode.Test
{
    [TestClass]
    public class RomanToIntegerTest
    {
        RomanToInteger romanToInteger = new RomanToInteger();

        [TestMethod]
        public void RomanToInt()
        {
            Assert.AreEqual(romanToInteger.RomanToInt("I"), 1);
            Assert.AreEqual(romanToInteger.RomanToInt("II"), 2);
            Assert.AreEqual(romanToInteger.RomanToInt("III"), 3);
            Assert.AreEqual(romanToInteger.RomanToInt("IV"), 4);
            Assert.AreEqual(romanToInteger.RomanToInt("V"), 5);
            Assert.AreEqual(romanToInteger.RomanToInt("VI"), 6);
            Assert.AreEqual(romanToInteger.RomanToInt("VII"), 7);
            Assert.AreEqual(romanToInteger.RomanToInt("VIII"), 8);
            Assert.AreEqual(romanToInteger.RomanToInt("IX"), 9);
            Assert.AreEqual(romanToInteger.RomanToInt("X"), 10);
            Assert.AreEqual(romanToInteger.RomanToInt("XI"), 11);
            Assert.AreEqual(romanToInteger.RomanToInt("XV"), 15);
            Assert.AreEqual(romanToInteger.RomanToInt("LXV"), 65);
            Assert.AreEqual(romanToInteger.RomanToInt("LXXX"), 80);
            Assert.AreEqual(romanToInteger.RomanToInt("CMXCIX"), 999);
            Assert.AreEqual(romanToInteger.RomanToInt("M"), 1000);
            Assert.AreEqual(romanToInteger.RomanToInt("MMMCMXCIX"), 3999);
        }
    }
}
