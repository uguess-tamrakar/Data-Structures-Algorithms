using System;
using System.Collections.Generic;

namespace Data_Structures___Algorithms
{
    public class Tree
    {
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            IList<IList<int>> result = new List<IList<int>>();
            FindPaths(root, new List<int>(), result, sum);
            return result;
        }

        private void FindPaths(TreeNode root, List<int> current, IList<IList<int>> result, int remaining)
        {
            if (root == null) return;

            current.Add(root.val);
            if (root.val == remaining && root.left == null && root.right == null){
                result.Add(current);
                return;
            }

            FindPaths(root.left, new List<int>(current), result, remaining - root.val);
            FindPaths(root.right, new List<int>(current), result, remaining - root.val);
        }

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (p.val < root.val && q.val < root.val) return LowestCommonAncestor(root.left, p, q);
            else if (p.val > root.val && q.val > root.val) return LowestCommonAncestor(root.right, p, q);
            else return root;
        }

        public static TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            TreeNode result = null;

            if (inorder.Length > 0 && inorder.Length == postorder.Length)
            {
                result = new TreeNode(postorder[postorder.Length - 1]);
                Stack<TreeNode> nodeStack = new Stack<TreeNode>();
                nodeStack.Push(result);
                TreeNode Temp = null;

                for (int i = inorder.Length - 2, j = postorder.Length - 1; i >= 0; i--)
                {
                    TreeNode current = new TreeNode(postorder[i]);
                    while (nodeStack.Count > 0 && nodeStack.Peek().val == inorder[j])
                    {
                        Temp = nodeStack.Pop();
                        j--;
                    }

                    if (Temp != null)
                    {
                        Temp.left = current; Temp = null;
                    }
                    else
                    {
                        nodeStack.Peek().right = current;
                    }

                    nodeStack.Push(current);
                }
            }

            return result;
        }

        private static int sum = 0;
        public static TreeNode ConvertBST(TreeNode root)
        {
            if (root != null) 
            {
                ConvertBST(root.right);
                sum += root.val;
                root.val = sum;
                ConvertBST(root.left);
            }

            return root;
        }

        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            bool result = false;

            if (p == null && q == null) result = true;
            else if (p != null && q != null)
            {
                result = p.val == q.val;
                if (result) result = IsSameTree(p.left, q.left);
                if (result) result = IsSameTree(p.right, q.right);
            }

            return result;
        }

        public bool IsSymmetric(TreeNode root)
        {
            Queue<TreeNode> NodeQueue = new Queue<TreeNode>();
            NodeQueue.Enqueue(root);
            NodeQueue.Enqueue(root);

            while (NodeQueue.Count > 0)
            {
                TreeNode LeftNode = NodeQueue.Dequeue();
                TreeNode RightNode = NodeQueue.Dequeue();

                if (LeftNode == null && RightNode == null) continue;
                if (LeftNode == null || RightNode == null) return false;
                if (LeftNode.val != RightNode.val) return false;

                NodeQueue.Enqueue(LeftNode.left);
                NodeQueue.Enqueue(RightNode.right);
                NodeQueue.Enqueue(LeftNode.right);
                NodeQueue.Enqueue(RightNode.left);
            }

            return true;
        }

        public static int MaxDepth(TreeNode root)
        {
            int result = 0;
            if (root != null)
            {
                result += 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
            }
            return result;
        }

        public static TreeNode InvertTree(TreeNode root)
        {
            TreeNode result = root;

            if (result != null)
            {
                TreeNode Temp = result.left;
                result.left = InvertTree(result.right);
                result.right = InvertTree(Temp);
            }

            return result;
        }

        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<List<int>> result = new List<List<int>>();

            Queue<TreeNode> queue = new Queue<TreeNode>();
            List<int> current;
            if (root != null)
            {
                queue.Enqueue(root);

                while (queue.Count != 0)
                {
                    int queueSize = queue.Count;
                    current = new List<int>();

                    for (int i = 0; i < queueSize; i++)
                    {
                        TreeNode node = queue.Dequeue();

                        if (node != null)
                        {
                            current.Add(node.val);

                            if (node.left != null)
                            {
                                queue.Enqueue(node.left);
                            }

                            if (node.right != null)
                            {
                                queue.Enqueue(node.right);
                            }
                        }
                    }

                    result.Add(current);
                }
            }

            return result.ToArray();
        }

        public static TreeNode ConvertArrayToTree(int[] array)
        {
            return GetTreeNode(array, null, 0);
        }

        private static TreeNode GetTreeNode(int[] array, TreeNode root, int i)
        {
            if (i < array.Length)
            {
                TreeNode temp = new TreeNode(array[i]);
                root = temp;
                root.left = GetTreeNode(array, root.left, 2 * i + 1);
                root.right = GetTreeNode(array, root.right, 2 * i + 2);
            }

            return root;
        }

    }

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}