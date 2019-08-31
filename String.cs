using System;
using System.Collections.Generic;

namespace Data_Structures___Algorithms
{
    public class StringSolution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int result = 0;

            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0, j = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i])) j = Math.Max(dict[s[i]], j);
                result = Math.Max(result, i - j + 1);
                if (!dict.ContainsKey(s[i])) dict.Add(s[i], i + 1);
                else dict[s[i]] = j + 1;
            }

            return result;
        }
    }
}