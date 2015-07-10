using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
	public class SearchInsertPosition
	{
		public int SearchInsert(int[] nums, int target)
		{
			var searchStartIndex = 0;
			var searchEndIndex = nums.Length;

			if (target > nums.Last())
				return nums.Length;
			else if (target < nums.First())
				return 0;

			while (searchEndIndex > searchStartIndex)
			{
				var middle = (searchStartIndex + searchEndIndex) / 2;

				if (nums[middle] >= target)
					searchEndIndex = middle;
				else if (searchStartIndex != middle)
					searchStartIndex = middle;
				else
					searchStartIndex = searchEndIndex;
			}

			return searchStartIndex;
		}
	}
}
