using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Code;

namespace LeetCode.Test
{
    [TestClass]
    public class RegularExpressionMatchingTest
    {
        RegularExpressionMatching regularExpressionMatching;

        public RegularExpressionMatchingTest()
        {
            this.regularExpressionMatching = new RegularExpressionMatching();
        }

        [TestMethod]
        public void IsMatch()
        {
            Assert.IsTrue(regularExpressionMatching.IsMatch("aab", "a*a*b*"));
            Assert.IsTrue(regularExpressionMatching.IsMatch("aaaaaaaaaaaaab", "a*a*a*a*a*a*a*a*a*a*a*a*b*"));
            Assert.IsTrue(regularExpressionMatching.IsMatch("aa", "aa"));
            Assert.IsFalse(regularExpressionMatching.IsMatch("ab", ".*c"));
            Assert.IsTrue(regularExpressionMatching.IsMatch("aaa", "ab*ac*a"));
            Assert.IsTrue(regularExpressionMatching.IsMatch("a", "ab*"));
            Assert.IsFalse(regularExpressionMatching.IsMatch("a", "ab*a"));
            Assert.IsTrue(regularExpressionMatching.IsMatch("cbaacacaaccbaabcb", "c*b*b*.*ac*.*bc*a*"));
        }
    }
}
