using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Code;

namespace LeetCode.Test
{
    [TestClass]
    public class IntegerToRomanTest
    {
        IntegerToRoman integerToRoman = new IntegerToRoman();

        [TestMethod]
        public void IntToRoman()
        {
            Assert.AreEqual(integerToRoman.IntToRoman(1), "I");
            Assert.AreEqual(integerToRoman.IntToRoman(2), "II");
            Assert.AreEqual(integerToRoman.IntToRoman(3), "III");
            Assert.AreEqual(integerToRoman.IntToRoman(4), "IV");
            Assert.AreEqual(integerToRoman.IntToRoman(5), "V");
            Assert.AreEqual(integerToRoman.IntToRoman(6), "VI");
            Assert.AreEqual(integerToRoman.IntToRoman(7), "VII");
            Assert.AreEqual(integerToRoman.IntToRoman(8), "VIII");
            Assert.AreEqual(integerToRoman.IntToRoman(9), "IX");
            Assert.AreEqual(integerToRoman.IntToRoman(10), "X");
            Assert.AreEqual(integerToRoman.IntToRoman(11), "XI");
            Assert.AreEqual(integerToRoman.IntToRoman(15), "XV");
            Assert.AreEqual(integerToRoman.IntToRoman(65), "LXV");
            Assert.AreEqual(integerToRoman.IntToRoman(80), "LXXX");
            Assert.AreEqual(integerToRoman.IntToRoman(999), "CMXCIX");
            Assert.AreEqual(integerToRoman.IntToRoman(1000), "M");
            Assert.AreEqual(integerToRoman.IntToRoman(3999), "MMMCMXCIX");
        }
    }
}
