using System;
using System.Collections.Generic;

namespace Data_Structures___Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // int result = StringSolution.LengthOfLongestSubstring("abcabcbb");
            // string result = new StringSolution().LongestPalindrome("babad");
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
            // int[] arrayNums = { 2,3,5 };
            // IList<IList<int>> result = new CombinationSum().CombinationSum2(arrayNums, 8);
            // bool result = (new BitManipulation()).IsPowerOfTwo(33);
            // int result = (new ArraySolution()).SingleNumber2(new int[] { 4, 1, 2, 1, 2 });
            // int result = (new StringSolution()).FirstUniqueChar("cc");
            // ListNode L1 = LinkedList.ListNodeFromArray(new int[] { 2, 4, 3 });
            // ListNode L2 = LinkedList.ListNodeFromArray(new int[] { 5, 6, 4 });
            // ListNode node = (new LinkedList()).AddTwoNumbers(L1, L2);
            // int result = new ArraySolution().RemoveElement(new int[] { 0,1,2,2,3,0,4,2 }, 2);

            // ListNode head = LinkedList.ListNodeFromArray(new int[] { 1, 2, -3, 3, 1 });
            // ListNode result = new LinkedList().RemoveZeroSumSublists(head);

            // char[][] Island = new char[4][];
            // Island[0] = new char[4] { 'O', 'O', 'O', 'O' };
            // Island[1] = new char[4] { 'D', 'O', 'D', 'O' };
            // Island[2] = new char[4] { 'O', 'O', 'O', 'O' };
            // Island[3] = new char[4] { 'X', 'D', 'D', 'O' };
            // int result = new ArraySolution().FindTreasureIsland(Island);
            // int[] result = new ArraySolution().TwoSum(new int[] { 2, 7, 11, 15 }, 18);
            // new StackSolution().Test();
            // int[] array = { 3, 2, 5, 1, 4, 6, 7 };
            // TreeNode Root = Tree.ConvertArrayToTree(array);
            // int result = Tree.MaxDepth(Root);
            int[] result = new ArraySolution().BubbleSort(new int[] { 4, 1, 2, 3 });
        }

        private static int Power(int x, int y)
        {
            return (int)Math.Pow(x, y);
        }
    }
}
