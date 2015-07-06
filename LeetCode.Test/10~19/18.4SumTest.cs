using LeetCode.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Test
{
    [TestClass]
    public class _4SumTest
    {
        _4Sum _4Sum = new _4Sum();

        void AssertEquals(IList<IList<int>> firstList, IList<IList<int>> secondList)
        {
            Assert.AreEqual(firstList.Count(), secondList.Count());

            firstList = firstList
                .OrderBy(list => list[0])
                .ThenBy(list => list[1])
                .ThenBy(list => list[2])
                .ThenBy(list => list[3])
                .ToList();

            secondList = secondList
                .OrderBy(list => list[0])
                .ThenBy(list => list[1])
                .ThenBy(list => list[2])
                .ThenBy(list => list[3])
                .ToList();

            Assert
                .IsTrue(firstList
                    .Zip(secondList
                        , (firstSubList, secondSubList) =>
                            firstSubList
                                .Zip(secondSubList
                                    , (first, second) =>
                                        first == second)
                                .All(item => item))
                    .All(item => item));
        }

        [TestMethod]
        public void FourSum()
        {
            this.AssertEquals(_4Sum.FourSum(new int[] { 1, 0, -1, 0, -2, 2 }, 0)
                , new List<IList<int>>
                {
                    new List<int>() { -1, 0, 0, 1 }
                    , new List<int>() { -2, -1, 1, 2 }
                    , new List<int>() { -2, 0, 0, 2 }
                });
        }
    }
}
