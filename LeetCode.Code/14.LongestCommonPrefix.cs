using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
	public class LongestCommonPrefix_
	{
		public string LongestCommonPrefix(string[] strs)
		{
			var index = -1;

			return new string(strs
				.DefaultIfEmpty(string.Empty)
				.FirstOrDefault()
				.TakeWhile(@char =>
					(++index >= 0)
					&& !strs
						.Any(@string =>
							@string.Length <= index
							|| @string[index] != @char))
				.ToArray());
		}

		public string LongestCommonPrefix2(string[] strs)
		{
			var lastResult = strs.FirstOrDefault();

			foreach (var @string in strs.Skip(1))
				lastResult = new string(lastResult
					.Zip(@string
						, (first, seconde) =>
							first == seconde
							? first
							: '\0')
					.TakeWhile(@char => @char != '\0')
					.ToArray());

			return lastResult ?? string.Empty;
		}
		
		public string LongestCommonPrefix3(string[] strs)
		{
			var endIndex = int.MaxValue;

			foreach (var @string in strs)
			{
				if (@string.Length - 1 < endIndex)
					endIndex = @string.Length - 1;

				var newEndIndex = -1;
				while (newEndIndex < endIndex
					&& strs[0][newEndIndex + 1] == @string[newEndIndex + 1])
					newEndIndex++;

				endIndex = newEndIndex;

				if (endIndex < 0)
					break;
			}

			return strs.Length > 0
				? strs[0].Substring(0, endIndex + 1)
				: string.Empty;
		}
	}
}
