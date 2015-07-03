using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Code;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class LetterCombinationsOfAPhoneNumberTest
    {
        LetterCombinationsOfAPhoneNumber letterCombinationsOfAPhoneNumber = new LetterCombinationsOfAPhoneNumber();

        void AssertEquers(IList<string> firstList, IList<string> secondList)
        {
            Assert.AreEqual(firstList.Count(), secondList.Count());

            firstList = firstList.OrderBy(item => item).ToList();
            secondList = secondList.OrderBy(item => item).ToList();

            Assert
                .IsTrue(firstList
                    .Zip(secondList
                        , (first, second) =>
                            first == second)
                    .All(item => item));
        }

        [TestMethod]
        public void LetterCombinations()
        {
            this.AssertEquers(letterCombinationsOfAPhoneNumber.LetterCombinations("23")
                , new List<string> { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" });

            this.AssertEquers(letterCombinationsOfAPhoneNumber.LetterCombinations("")
                , new List<string> { });
        }
    }
}
