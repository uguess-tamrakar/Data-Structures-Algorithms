using System;
using System.Collections.Generic;

namespace Data_Structures___Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // int result = StringSolution.LengthOfLongestSubstring("abbab");
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
            string[] logs = { "dig1 8 1 5 1","let1 art can","dig2 3 6","let2 own kit dig","let3 art zero" };
            StringSolution.ReorderLogFiles(logs);
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
            // int[] result = new ArraySolution().BubbleSort(new int[] { 4, 1, 2, 3 });
            // bool IsPalindrome = 321123.IsPalindrome();
            // int Reverse = -1111111113.Reverse();
            // int[] Array = { 0,0,0,0};
            // IList<IList<int>> Result =  Array.ThreeSumToZero();
            // int[] Array = { 1, 2, 3, 4, 5 };
            // bool result = Array.HasIncreasingTriplet();
            // TimeMap timeMap = new TimeMap();
            // timeMap.Set("love", "high", 10);
            // timeMap.Set("love", "mid", 12);
            // timeMap.Set("love", "low", 20);
            // string test = timeMap.Get("love", 5);
            // string test1 = timeMap.Get("love", 10);
            // string test2 = timeMap.Get("love", 15);
            // string test3 = timeMap.Get("love", 20);
            // string test4 = timeMap.Get("love", 25);
            // int[][] Image = {
            //     new int[] {0, 0, 0},
            //     new int[] {0, 1, 1}
            // };
            // int[][] modified = new DepthFirstSearch().FloodFill(Image, 1, 1, 1);
            // int[] Array = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            // int result = new DynamicProgramming().TrapUsingPointers(Array);
            //             int result = new StringSolution().KSimilarity(
            //                                                         "aabbccddee",
            // "cbeddebaac");
            // IList<IList<string>> result = new BreadthFirstSearch().FindLadders("hit", "cog", new List<string>() { "hot", "dot", "dog", "lot", "log", "cog" });
            // int[] result = new ArraySolution().SearchRange(new int[] { 1, 6,6,6,6,6,6,6 }, 6);
            // RandomLinkedNode head = new RandomLinkedNode(1, new RandomLinkedNode(2, null, null), new RandomLinkedNode(2, null, null));
            // RandomLinkedNode result = new RandomLinkedNodeSolution().CopyRandomList(head);
            // string result = new StringSolution().AddStringsFaster("123", "99999");
            // int result = DynamicProgramming.CoinChangeRecursively(new int[] { 1, 2, 5 }, 11);
        }

        private static int Power(int x, int y)
        {
            return (int)Math.Pow(x, y);
        }
    }
}
