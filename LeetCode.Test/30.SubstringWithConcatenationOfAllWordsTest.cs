using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
	[TestClass]
	public class SubstringWithConcatenationOfAllWordsTest
	{
		SubstringWithConcatenationOfAllWords substringWithConcatenationOfAllWords = new SubstringWithConcatenationOfAllWords();

		void AssertEquals(IList<int> subject, IList<int> @object)
		{
			Assert.AreEqual(subject.Count, @object.Count);

			Assert.IsTrue(subject
				.Zip(@object
					, (first, second) => first == second)
				.All(item => item));
		}

		[TestMethod]
		public void FindSubstring()
		{
			this.AssertEquals(substringWithConcatenationOfAllWords.FindSubstring("barfoothefoobarman", new string[] { "foo", "bar" })
				, new List<int> { 0, 9 });
			this.AssertEquals(substringWithConcatenationOfAllWords.FindSubstring("barfoothefoobarman", new string[] { })
				, new List<int> { });
			this.AssertEquals(substringWithConcatenationOfAllWords.FindSubstring("barfoothefoobarman", new string[] { "b" })
				, new List<int> { 0, 12 });
		}
	}
}
