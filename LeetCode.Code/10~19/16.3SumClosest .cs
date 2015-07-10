using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
	public class _3SumClosest
	{
		public int ThreeSumClosest(int[] nums, int target)
		{
			var numbers = nums.OrderBy(number => number).ToArray();

			var result = 0;
			var closest = int.MaxValue;

			for (var firstIndex = 0; firstIndex < numbers.Length - 2; firstIndex++)
			{
				var secondIndex = firstIndex + 1;
				var thirdIndex = numbers.Length - 1;
				while (secondIndex < thirdIndex)
				{
					int sum = numbers[firstIndex] + numbers[secondIndex] + numbers[thirdIndex];
					int distance = Math.Abs(sum - target);

					if (distance < closest)
					{
						closest = distance;
						result = sum;
					}

					if (sum > target)
						thirdIndex--;
					else
						secondIndex++;
				}
			}

			return result;
		}
	}
}
