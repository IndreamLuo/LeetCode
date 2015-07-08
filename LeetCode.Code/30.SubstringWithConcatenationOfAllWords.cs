using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
	public class SubstringWithConcatenationOfAllWords
	{
		public IList<int> FindSubstring(string s, string[] words)
		{
			var result = new List<int>();

			if (words.Length == 0)
				return result;

			var wordLength = words[0].Length;

			var wordCount = new Dictionary<string, int>();
			foreach (var word in words)
				if (wordCount.ContainsKey(word))
					wordCount[word]++;
				else
					wordCount[word] = 1;

			var queue = new Queue<string>();
			var concatenationLength = words.Length * wordLength;
			for (var index = 0; index < wordLength; index++)
			{
				for (var subIndex = index; subIndex < s.Length - wordLength + 1; subIndex += wordLength)
				{
					var subString = s.Substring(subIndex, wordLength);
					if (wordCount.ContainsKey(subString))
					{
						queue.Enqueue(subString);
						wordCount[subString]--;

						while (wordCount[subString] < 0)
							wordCount[queue.Dequeue()]++;

						if (queue.Count == words.Length)
							result.Add(subIndex + wordLength - concatenationLength);
					}
					else
						while (queue.Count > 0)
							wordCount[queue.Dequeue()]++;
				}

				while (queue.Count > 0)
					wordCount[queue.Dequeue()]++;
			}

			return result;
		}
	}
}
