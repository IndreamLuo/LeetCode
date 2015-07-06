using System;
using System.Linq;
using LeetCode.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
	[TestClass]
	public class RemoveElementTest
	{
		RemoveElement_ removeElement = new RemoveElement_();

		void AssertRight(int[] originArray, int length, int[] array)
		{
			var target = originArray
				.Where(item => item != originArray[0])
				.OrderBy(item => item);

			var compare = array
				.Take(length)
				.OrderBy(item => item);

			Assert.AreEqual(length, target.Count());

			Assert.IsTrue(target
				.Zip(compare
					, (first, second) =>
					first == second)
				.All(item => item));
		}

		[TestMethod]
		public void RemoveElement()
		{
			var arrayLength = 100;
			var array = new int[100];
			var random = new Random(Guid.NewGuid().GetHashCode());
			var repeatTimes = 5;
			for (var index = 0; index < arrayLength; index++)
			{
				var number = random.Next(int.MaxValue);
				var end = index + random.Next(1, repeatTimes);
				for (; index < arrayLength && index < end; index++)
				{
					array[index] = number;
				}
			}
			array = array.OrderBy(item => random.Next(int.MaxValue)).ToArray();
			var newArray = array.ToArray();

			this.AssertRight(array, removeElement.RemoveElement(newArray, newArray[0]), newArray);
		}
	}
}
