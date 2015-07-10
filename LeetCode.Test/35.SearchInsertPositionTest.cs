using System;
using LeetCode.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
	[TestClass]
	public class SearchInsertPositionTest
	{
		SearchInsertPosition searchInsertPosition = new SearchInsertPosition();

		[TestMethod]
		public void SearchInsert()
		{
			Assert.AreEqual(2, searchInsertPosition.SearchInsert(new int[] { 1, 3, 5, 6 }, 5));
			Assert.AreEqual(1, searchInsertPosition.SearchInsert(new int[] { 1, 3, 5, 6 }, 2));
			Assert.AreEqual(4, searchInsertPosition.SearchInsert(new int[] { 1, 3, 5, 6 }, 7));
			Assert.AreEqual(0, searchInsertPosition.SearchInsert(new int[] { 1, 3, 5, 6 }, 0));
		}
	}
}
