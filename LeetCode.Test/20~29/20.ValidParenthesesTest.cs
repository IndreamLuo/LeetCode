using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Code;

namespace LeetCode.Test
{
    [TestClass]
    public class ValidParenthesesTest
    {
        ValidParentheses validParenthese = new ValidParentheses();

        [TestMethod]
        public void IsValid()
        {
            Assert.IsFalse(validParenthese.IsValid("["));
            Assert.IsTrue(validParenthese.IsValid("{[]}()"));
            Assert.IsFalse(validParenthese.IsValid("{[}()"));
        }
    }
}
