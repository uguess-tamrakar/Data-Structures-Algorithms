using System;
using System.Collections.Generic;

namespace Data_Structures___Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //int result = StringSolution.LengthOfLongestSubstring("abcabcbb");
            // TreeNode test = new TreeNode(5);
            // test.left = new TreeNode(2);
            // test.right = new TreeNode(13);
            // TreeNode result = Tree.ConvertBST(test);

            // RandomizedSet RandomSet = new RandomizedSet();
            // RandomSet.Insert(1);
            // RandomSet.Insert(10);
            // RandomSet.Insert(20);
            // RandomSet.Insert(30);
            // RandomSet.GetRandom();
            // char[][] input = 
            // { 
            //     new char[] { '1', '1', '1', '1', '0' },
            //     new char[] { '1', '1', '0', '1', '0' },
            //     new char[] { '1', '1', '0', '0', '0' },
            //     new char[] { '0', '0', '0', '0', '0' },
            // };
            // int result = DynamicProgramming.NumIslands(input);
            // int[] Array1 = { 1, 2, 3, 0, 0, 0 };
            // int[] Array2 = { 2, 5, 6 };
            // ArraySolution.Merge(Array1, 3, Array2, 3);
            // string[] logs = { "a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo" };
            // StringSolution.ReorderLogFiles(logs);
            // int[] arrayNums = { -1,0,1,2,-1,-4 };
            // IList<IList<int>> result = CombinationSum.ThreeSum(arrayNums);
            // bool result = (new BitManipulation()).IsPowerOfTwo(33);
            // int result = (new ArraySolution()).SingleNumber2(new int[] { 4, 1, 2, 1, 2 });
            int result = (new StringSolution()).FirstUniqueChar("cc");
        }
    }
}
