using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Data_Structures___Algorithms
{
    public class StringSolution
    {
        public string AddStringsFaster(string num1, string num2)
        {
            string result = string.Empty;

            int index1 = num1.Length - 1;
            int index2 = num2.Length - 1;
            int carry = 0;

            while (index1 > -1 || index2 > -1 || carry > 0) {
                int numX = 0;
                int numY = 0;
                
                if (index1 > -1) {
                    numX = num1[index1] - '0';
                    index1--;
                }

                if (index2 > -1) {
                    numY = num2[index2] - '0';
                    index2--;
                }

                result = ((numX + numY + carry) % 10) + result;
                carry = ((numX + numY + carry) / 10);
            }

            return result;
        }

        public string AddStrings(string num1, string num2)
        {
            string result = string.Empty;

            int index1 = num1.Length - 1;
            int index2 = num2.Length - 1;
            int carry = 0;

            while (index1 > -1 || index2 > -1 || carry > 0) {
                int numX = 0;
                int numY = 0;
                
                if (index1 > -1) {
                    numX = num1[index1] - '0';
                    index1--;
                }

                if (index2 > -1) {
                    numY = num2[index2] - '0';
                    index2--;
                }

                result += ((numX + numY + carry) % 10).ToString();
                carry = ((numX + numY + carry) / 10);
            }

            return new string(result.Reverse().ToArray());
        }

        public int KSimilarity(string A, string B)
        {
            int result = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != B[i])
                {
                    int index = FindIndexToSwapAt(i, A, B);
                    A = Swap(A, i, index);
                    result++;
                }
            }

            return result;
        }

        private int FindIndexToSwapAt(int currentIndex, string s1, string s2)
        {
            int result = currentIndex;

            for (int i = currentIndex + 1; i < s1.Length; i++)
            {
                // Find common index where we can just switch
                if (s1[i] == s2[currentIndex] && s2[i] == s1[currentIndex])
                {
                    result = i;
                    break;
                }
                // Find index where A and B char do not match 
                else if (s1[i] != s2[i] && s2[currentIndex] == s1[i])
                {
                    result = i;
                }
            }

            return result;
        }

        private string Swap(string A, int x, int y)
        {
            char[] chars = A.ToCharArray();
            char temp = chars[x];
            chars[x] = chars[y];
            chars[y] = temp;
            return new string(chars);
        }        

        public bool IsPalindrome(string s)
        {
            bool result = true;
            Stack<char> Stack = new Stack<char>();
            Queue<char> Queue = new Queue<char>();

            foreach (char c in s)
            {
                Stack.Push(c);
                Queue.Enqueue(c);
            }

            for (int i = 0; i < s.Length / 2; i++)
            {
                if (Stack.Pop() != Queue.Dequeue()) {
                    result = false;
                    break;
                }
            }

            return result;
        }

        public string LongestPalindrome(string s) 
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;
            int start = 0;
            int end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int length1 = ExpandFromCenter(s, i, i);
                int length2 = ExpandFromCenter(s, i, i + 1);
                int length = Math.Max(length1, length2);

                if (length > end - start) {
                    start = i - (length - 1) / 2;
                    end = i + length / 2;
                }
            }

            return s.Substring(start, end - start + 1);
        }

        private int ExpandFromCenter(string s, int left, int right)
        {
            while (left > -1 && right < s.Length && s[left] == s[right]){
                left--;
                right++;
            }
            return right - left - 1;
        }

        public bool JudgeCircle(string moves)
        {
            int x = 0;
            int y = 0;
            
            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'U' || moves[i] == 'u') y++;
                else if (moves[i] == 'D' || moves[i] == 'd') y--;
                else if (moves[i] == 'L' || moves[i] == 'l') x--;
                else if (moves[i] == 'R' || moves[i] == 'r') x++;
            }

            return (x == 0 && y == 0);
        }

        public int FirstUniqueChar(String s)
        {
            if (string.IsNullOrEmpty(s)) return -1;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i])) dict.Add(s[i], i);
                else dict[s[i]] = -1;
            }

            foreach (KeyValuePair<char, int> pair in dict)
            {
                if (pair.Value != -1)
                {
                    return pair.Key;
                }
            }
            return -1;
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int leftPointer = 0;
            int rightPointer = 0;
            int max = 0;
            HashSet<char> uniqueChars = new HashSet<char>();

            while (rightPointer < s.Length)
            {
                if (uniqueChars.Contains(s[rightPointer]))
                {
                    uniqueChars.Remove(s[leftPointer]);
                    leftPointer++;
                }
                else
                {
                    uniqueChars.Add(s[rightPointer]);
                    rightPointer++;
                    max = Math.Max(max, uniqueChars.Count);
                }
            }

            return max;
        }

        public static string[] ReorderLogFiles(string[] logs)
        {
            // if (logs == null) return null;
            // else if (logs.Length == 0) return new string[0];

            // List<string> result = new List<string>();

            // List<string> letterLogs = new List<string>();
            // List<string> digitLogs = new List<string>();
            // for (int i = 0; i < logs.Length; i++)
            // {
            //     string afterIdentifier = logs[i].Split(' ')[1];
            //     if (char.IsDigit(afterIdentifier[0])) digitLogs.Add(logs[i]);
            //     else letterLogs.Add(logs[i]);
            // }

            // letterLogs = letterLogs.OrderBy(log => log).ToList();
            // result = letterLogs.OrderBy(log => log.Substring(log.IndexOf(' ') + 1)).ToList();
            // result.AddRange(digitLogs);

            // return result.ToArray();
            List<string> letterLogs = new List<string>();
            List<string> digitLogs = new List<string>();
            for (int i = 0; i < logs.Length; i++)
            {
                if (char.IsLetter(logs[i].Split(" ")[1][0])) letterLogs.Add(logs[i]);
                else digitLogs.Add(logs[i]);
            }
            
            Array.Sort(letterLogs.ToArray());
            Array.Sort(letterLogs.ToArray(), CompareStrings);
            letterLogs.AddRange(digitLogs);
            return letterLogs.ToArray();
        }

        private static int CompareStrings(string s1, string s2)
        {
            return new CaseInsensitiveComparer().Compare(s1.Split(" ")[1], s2.Split(" ")[1]);
        }
    }
}