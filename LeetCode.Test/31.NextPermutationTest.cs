using System;
using System.Linq;
using LeetCode.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
	[TestClass]
	public class NextPermutationTest
	{
		NextPermutation_ nextPermutation = new NextPermutation_();

		void AssertEquals(int[] subject, int[] @object)
		{
			Assert.AreEqual(subject.Length, @object.Length);
			Assert.IsTrue(subject
				.Zip(@object
					, (first, second) => first == second)
				.All(item => item));
		}

		[TestMethod]
		public void NextPermutation()
		{
			int[] array;
			nextPermutation.NextPermutation(array = new int[] { 1, 2, 3 });
			this.AssertEquals(new int[] { 1, 3, 2 }, array);

			nextPermutation.NextPermutation(array = new int[] { 3, 2, 1 });
			this.AssertEquals(new int[] { 1, 2, 3 }, array);

			nextPermutation.NextPermutation(array = new int[] { 1, 1, 5 });
			this.AssertEquals(new int[] { 1, 5, 1 }, array);

			nextPermutation.NextPermutation(array = new int[] { 2, 3, 1 });
			this.AssertEquals(new int[] { 3, 1, 2 }, array);
		}
	}
}
