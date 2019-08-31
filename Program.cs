using System;

namespace Data_Structures___Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //int result = StringSolution.LengthOfLongestSubstring("abcabcbb");
            TreeNode test = new TreeNode(5);
            test.left = new TreeNode(2);
            test.right = new TreeNode(13);
            TreeNode result = Tree.ConvertBST(test);
        }
    }
}
