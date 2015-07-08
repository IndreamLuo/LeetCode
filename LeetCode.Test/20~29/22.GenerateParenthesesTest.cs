using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Code;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class GenerateParenthesesTest
    {
        GenerateParentheses generateParentheses = new GenerateParentheses();

        void AssertEquals(IList<string> firstList, IList<string> secondList)
        {
            Assert.AreEqual(firstList.Count, secondList.Count);

            firstList = firstList.OrderBy(item => item).ToList();
            secondList = secondList.OrderBy(item => item).ToList();

            Assert.IsTrue(firstList
                .Zip(secondList
                    , (first, second) => first == second)
                .All(item => item));
        }

        [TestMethod]
        public void GenerateParenthesis()
        {
            this.AssertEquals(generateParentheses.GenerateParenthesis(3)
                , new List<string>
                {
                    "((()))", "(()())", "(())()", "()(())", "()()()" 
                });
        }
    }
}
