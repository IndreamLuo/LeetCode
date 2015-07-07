using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
	public class ImplementStrStr
	{
		public int StrStr(string haystack, string needle)
		{
			int nextIndex = -1;

			for (var index = 0
				; index <= haystack.Length - needle.Length
				&& needle.Length > 0
				; index++)
			{
				if (haystack[index] == needle[0])
				{
					var compareIndex = index + 1;
					var end = index + needle.Length;
					for (
						; compareIndex < end
						&& haystack[compareIndex] == needle[compareIndex - index]
						; compareIndex++)
					{
						if (nextIndex == -1 && haystack[compareIndex] == needle[0])
							nextIndex = compareIndex;
					}

					if (compareIndex == end)
						return index;

					if (nextIndex != -1)
						index = nextIndex + (nextIndex = -1);
				}
			}

			return needle.Length > 0
				? -1
				: 0;
		}
	}
}
