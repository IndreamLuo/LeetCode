using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
	public class NextPermutation_
	{
		public void NextPermutation(int[] nums)
		{
			var index = nums.Length - 2;
			while (index >= 0
				&& nums[index] >= nums[index + 1])
				index--;

			var swapIndex = nums.Length - 1;
			while (index >= 0
				&& swapIndex > index
				&& nums[swapIndex] <= nums[index])
				swapIndex--;

			if (index < 0)
				swapIndex = nums.Length / 2;
			else
			{
				this.Swap(nums, index, swapIndex);

				for (var bubblingIndex = swapIndex
					; bubblingIndex < nums.Length - 1
					&& nums[bubblingIndex] < nums[bubblingIndex + 1]
					; bubblingIndex++)
					this.Swap(nums, bubblingIndex, bubblingIndex + 1);

				for (var bubblingIndex = swapIndex
					; bubblingIndex > index
					&& nums[bubblingIndex] > nums[bubblingIndex - 1]
					; bubblingIndex++)
					this.Swap(nums, bubblingIndex, bubblingIndex - 1);
			}

			var swapingIndex = -1;
			int leftIndex, rightIndex;
			while ((leftIndex
					= index + ++swapingIndex + 1)
				< (rightIndex
					= nums.Length - swapingIndex - 1))
				this.Swap(nums, leftIndex, rightIndex);
		}

		void Swap(int[] nums, int index, int swapIndex)
		{
			nums[index] += nums[swapIndex];
			nums[swapIndex] = nums[index] - nums[swapIndex];
			nums[index] -= nums[swapIndex];
		}
	}
}
