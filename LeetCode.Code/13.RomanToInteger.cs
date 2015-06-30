using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class RomanToInteger
    {
		static Dictionary<char, int> numberLetters = new Dictionary<char, int>
		{
			{ 'I', 1 },
			{ 'V', 5 },
			{ 'X', 10 },
			{ 'L', 50 },
			{ 'C', 100 },
			{ 'D', 500 },
			{ 'M', 1000 }
		};

        public int RomanToInt(string s)
        {
			var lastChar = s[0];
			var lastCharValue = RomanToInteger.numberLetters[lastChar];
			var tempValue = lastCharValue;
			var result = 0;

			foreach (var @char in s.Skip(1))
			{
				if (@char == lastCharValue)
					tempValue += lastCharValue;
				else
				{
					var currentCharValue = RomanToInteger.numberLetters[@char];
					result += currentCharValue > lastCharValue
						? -tempValue
						: tempValue;

					lastCharValue = currentCharValue;
					tempValue = currentCharValue;
				}
			}

			return result + tempValue;
        }
    }
}
