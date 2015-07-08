using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            var rewriteIndex = 0;

            for (var index = 1; index < nums.Length; index++)
                if (nums[index] != nums[index - 1])
                    nums[++rewriteIndex] = nums[index];

            return nums.Length == 0
                ? 0
                : ++rewriteIndex;
        }
    }
}
