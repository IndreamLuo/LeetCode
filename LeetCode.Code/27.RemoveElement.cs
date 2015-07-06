using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
	public class RemoveElement_
	{
		public int RemoveElement(int[] nums, int val)
		{
			var replaceIndex = -1;

			for (var index = 0; index < nums.Length; index++)
				if (nums[index] != val)
					nums[++replaceIndex] = nums[index];

			return nums.Length == 0
				? 0
				: replaceIndex + 1;
		}
	}
}
