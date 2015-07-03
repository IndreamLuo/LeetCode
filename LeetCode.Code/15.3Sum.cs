using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
	public class _3Sum
	{
		public IList<IList<int>> ThreeSum(int[] nums)
		{
			var numbers = nums
				.OrderBy(number => number)
				.ToArray();

			var positions = new Dictionary<int, int>();
			for (var index = 0; index < numbers.Length; index++)
				positions[numbers[index]] = index;

			var result = new List<IList<int>>();
			var secondEnd = numbers.Length - 1;
			for (var secondIndex = 1; secondIndex < secondEnd; secondIndex++)
			{
				var secondNumber = numbers[secondIndex];
				if (secondIndex > 1
					&& secondNumber == numbers[secondIndex - 2])
					continue;

				for (var firstIndex =
						secondNumber == numbers[secondIndex - 1]
							? secondIndex - 1
							: 0
					; firstIndex < secondIndex
						&& numbers[firstIndex] <= 0
					; firstIndex++)
				{
					var firstNumber = numbers[firstIndex];
					if (firstIndex > 0
						&& firstNumber == numbers[firstIndex - 1])
						continue;

					var thirdNumber = 0 - firstNumber - secondNumber;

					if (firstIndex == 0
						&& thirdNumber < secondNumber)
						return result;

					int thirdIndex;
					if (positions.TryGetValue(thirdNumber, out thirdIndex)
						&& thirdIndex > secondIndex)
						result.Add(new List<int> { firstNumber, secondNumber, thirdNumber });
				}
			}

			return result;
		}
	}
}
