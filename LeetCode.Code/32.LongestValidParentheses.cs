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

			for (var index = 0; index < s.Length; index++)
				if (s[index] == ')')
				{
					lastRightParentheses[index] = lastRightParentheseIndex;
					lastRightParentheseIndex = index;

					var currentRightParentheses = 1;
					var currentRightParentheseIndex = index;
					while (currentRightParentheseIndex > 0)
					{
						//if (currentRightParentheseIndex - lastRightParentheses[index] < currentRightParentheses)
						throw new NotImplementedException();
					}
				}

			return result;
		}
	}
}
