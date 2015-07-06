using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            var maxArea = 0;

            if (height.Length > 0)
            {
                var startIndexes = new Stack<int>();
                startIndexes.Push(0);
                for (var index = 1; index < height.Length; index++)
                    if (height[index] > height[startIndexes.Peek()])
                        startIndexes.Push(index);

                var endIndex = height.Length - 1;
                maxArea = startIndexes.Max(startIndex => (endIndex - startIndex) * (height[endIndex] > height[startIndex] ? height[startIndex] : height[endIndex]));
                for (var index = endIndex - 1; index >= 0; index--)
                    if (height[index] > height[endIndex])
                    {
                        endIndex = index;

                        while (startIndexes.Peek() > index)
                            startIndexes.Pop();

                        foreach (var startIndex in startIndexes)
                        {
                            var area = (index - startIndex) * (height[index] > height[startIndex] ? height[startIndex] : height[index]);
                            if (area > maxArea)
                                maxArea = area;
                        }
                    }
            }

            return maxArea;
        }
    }
}
