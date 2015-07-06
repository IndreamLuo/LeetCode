using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class _4Sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var numbers = nums
                .OrderBy(item => item)
                .ToArray();

            var lastPositions = new Dictionary<int, int>();
            for (var index = 0; index < numbers.Length; index++)
                lastPositions[numbers[index]] = index;

            var result = new List<IList<int>>();

            var thirdIndexEnd = nums.Length - 1;
            for (var thirdIndex = 2
                ; thirdIndex < thirdIndexEnd
                ; thirdIndex++)
            {
                var thirdNumber = numbers[thirdIndex];
                if (thirdIndex > 2
                    && thirdNumber == numbers[thirdIndex - 3])
                    continue;

                for (var secondIndex = 1
                    ; secondIndex < thirdIndex
                    ; secondIndex++)
                {
                    if (thirdNumber == numbers[thirdIndex - 1])
                        secondIndex = thirdIndex - 1;

                    var secondNumber = numbers[secondIndex];
                    if (secondIndex > 1
                        && secondNumber == numbers[secondIndex - 2])
                        continue;

                    for (var firstIndex = 0
                        ; firstIndex < secondIndex
                        ; firstIndex++)
                    {
                        if (secondNumber == numbers[secondIndex - 1])
                            firstIndex = secondIndex - 1;

                        var firstNumber = numbers[firstIndex];
                        if (firstIndex > 0
                            && firstNumber == numbers[firstIndex - 1])
                            continue;

                        var forthNumber = target - firstNumber - secondNumber - thirdNumber;
                        int forthIndex;
                        if (lastPositions.TryGetValue(forthNumber, out forthIndex)
                            && forthIndex > thirdIndex)
                            result.Add(new List<int> { firstNumber, secondNumber, thirdNumber, forthNumber });
                    }
                }
            }

            return result;
        }
    }
}
