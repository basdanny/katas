using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    internal class LongestSubstring : IRunTests
    {
        /// <summary>
        /// Given a string, find the longest substring without any letter repetition
        /// </summary>
        public string GetLongestSubstring(string input)
        {
            if (string.IsNullOrEmpty(input)) return "";

            int start = 0, maxLength = 0;
            string longestSubstring = "";
            Dictionary<char, int> charIndex = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (charIndex.ContainsKey(c))
                {
                    start = Math.Max(start, charIndex[c] + 1);
                }

                charIndex[c] = i;

                if (i - start + 1 > maxLength)
                {
                    maxLength = i - start + 1;
                    longestSubstring = input.Substring(start, maxLength);
                }
            }

            return longestSubstring;
        }

        public void RunTests()
        {
            Debug.Assert(GetLongestSubstring("abcabcbb") == "abc");
            Debug.Assert(GetLongestSubstring("abcabcdbb") == "abcd");
            Debug.Assert(GetLongestSubstring("abcadb") == "bcad");
        }
    }
}
