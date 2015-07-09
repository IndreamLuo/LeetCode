using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
	public class LongestValidParentheses_
	{
		public int LongestValidParentheses(string s)
		{
			var result = 0;

			var lastRightParentheseIndex = -1;
			var lastRightParentheses = new int[s.Length];
			var startIndexes = new int[s.Length];
			var isCloseds = new bool[s.Length];

			for (var index = 0; index < s.Length; index++)
				if (s[index] == ')')
				{
					lastRightParentheses[index] = lastRightParentheseIndex;
					startIndexes[index] = index;

					int currentRightParentheseIndex = index;
					int currentStartIndex;

					do
					{
						currentStartIndex = startIndexes[currentRightParentheseIndex] - 1;
						currentRightParentheseIndex = lastRightParentheses[currentRightParentheseIndex];
					} while (currentRightParentheseIndex >= 0
						&& currentStartIndex <= currentRightParentheseIndex);

					if (currentStartIndex >= 0)
					{
						if (currentStartIndex == 0)
							currentRightParentheseIndex = -1;
						else if (isCloseds[currentStartIndex - 1])
						{
							currentRightParentheseIndex = lastRightParentheses[currentStartIndex - 1];
							currentStartIndex = startIndexes[currentStartIndex - 1];
						}

						isCloseds[index] = true;

						if (index - currentStartIndex + 1 > result)
							result = index - currentStartIndex + 1;
					}

					startIndexes[index] = currentStartIndex;
					lastRightParentheses[index] = currentRightParentheseIndex;
					lastRightParentheseIndex = index;
				}

			return result;
		}
	}
}
