using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
	[TestClass]
	public class _3SumTest
	{
		_3Sum _3Sum = new _3Sum();

		void AssertEquals(IList<IList<int>> firstList, IList<IList<int>> secondList)
		{
			Assert.AreEqual(firstList.Count(), secondList.Count());

			firstList = firstList
				.OrderBy(list => list[0])
				.ThenBy(list => list[1])
				.ThenBy(list => list[2])
				.ToList();

			secondList = secondList
				.OrderBy(list => list[0])
				.ThenBy(list => list[1])
				.ThenBy(list => list[2])
				.ToList();

			Assert.IsTrue(firstList
				.Zip(secondList
					, (firstSubList, secondeSubList) =>
						firstSubList
							.Zip(secondeSubList
								, (first, second) =>
									first == second)
							.All(item => item))
				.All(item => item)); ;
		}

		[TestMethod]
		public void ThreeSum()
		{
			this.AssertEquals(_3Sum
					.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 })
				, new List<IList<int>>
				{
					new List<int> { -1, 0, 1 }
					, new List<int> { -1, -1, 2 }
				});

			this.AssertEquals(_3Sum
					.ThreeSum(new int[] { -1, 0, 1, 0 })
				, new List<IList<int>>
				{
					new List<int> { -1, 0, 1}
				});

			this.AssertEquals(_3Sum
					.ThreeSum(new int[] { 1, -1, -1, 0 })
				, new List<IList<int>>
				{
					new List<int> { -1, 0, 1}
				});

			this.AssertEquals(_3Sum
					.ThreeSum(new int[] { -4, -2, -2, -2, 0, 1, 2, 2, 2, 3, 3, 4, 4, 6, 6 })
				, new List<IList<int>>
				{
					 new List<int> { -4,-2, 6 }
					 , new List<int> { -4, 0, 4 }
					 , new List<int> { -4, 1, 3 }
					 , new List<int> { -4, 2, 2 }
					 , new List<int> { -2, -2, 4 }
					 , new List<int> { -2, 0, 2 }
				});
		}
	}
}
