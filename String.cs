using System;
using System.Collections.Generic;
using System.Linq;

namespace Data_Structures___Algorithms
{
    public class StringSolution
    {
        public int FirstUniqueChar(String s) {
            if (string.IsNullOrEmpty(s)) return -1;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i])) dict.Add(s[i], i);
                else dict[s[i]] = -1;
            }

            return dict.First(pair => pair.Value != -1).Value;
        }

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

        public static string[] ReorderLogFiles(string[] logs)
        {
            if (logs == null) return null;
            else if (logs.Length == 0) return new string[0];

            List<string> result = new List<string>();

            List<string> letterLogs = new List<string>();
            List<string> digitLogs = new List<string>();
            for (int i = 0; i < logs.Length; i++)
            {
                string afterIdentifier = logs[i].Split(' ')[1];
                if (char.IsDigit(afterIdentifier[0])) digitLogs.Add(logs[i]);
                else letterLogs.Add(logs[i]);
            }

            letterLogs = letterLogs.OrderBy(log => log).ToList();
            result = letterLogs.OrderBy(log => log.Substring(log.IndexOf(' ') + 1)).ToList();
            result.AddRange(digitLogs);

            return result.ToArray();
        }
    }
}