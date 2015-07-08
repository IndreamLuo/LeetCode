using System;
using LeetCode.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
	[TestClass]
	public class LongestValidParenthesesTest
	{
		LongestValidParentheses_ longestValidParenthese = new LongestValidParentheses_();

		[TestMethod]
		public void LongestValidParentheses()
		{
			Assert.AreEqual(4, longestValidParenthese.LongestValidParentheses(")()())"));
			Assert.AreEqual(2, longestValidParenthese.LongestValidParentheses("(()"));
			Assert.AreEqual(0, longestValidParenthese.LongestValidParentheses("("));
			Assert.AreEqual(2, longestValidParenthese.LongestValidParentheses("()(()"));
			Assert.AreEqual(8, longestValidParenthese.LongestValidParentheses("(()()(())(("));
			Assert.AreEqual(2, longestValidParenthese.LongestValidParentheses("(((()(()"));
		}
	}
}
