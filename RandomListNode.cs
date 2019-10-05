using System.Collections.Generic;

namespace Data_Structures___Algorithms
{

    // Definition for a Node.
    public class RandomLinkedNode
    {
        public int val;
        public RandomLinkedNode next;
        public RandomLinkedNode random;

        public RandomLinkedNode() { }
        public RandomLinkedNode(int _val, RandomLinkedNode _next, RandomLinkedNode _random)
        {
            val = _val;
            next = _next;
            random = _random;
        }
    }

    public class RandomLinkedNodeSolution
    {
        public RandomLinkedNode CopyRandomList(RandomLinkedNode head)
        {
            RandomLinkedNode result = null;

            if (head != null)
            {
                Dictionary<RandomLinkedNode, RandomLinkedNode> dict = new Dictionary<RandomLinkedNode, RandomLinkedNode>();
                RandomLinkedNode current = head;
                while (current != null)
                {
                    dict.Add(current, new RandomLinkedNode(current.val, current.next, current.random));
                    current = current.next;
                }

                current = head;
                while (current != null)
                {
                    dict[current].next = current.next == null ? null : dict[current.next];
                    dict[current].random = current.random == null ? null : dict[current.random];
                    current = current.next;
                }

                result = dict[head];
            }

            return result;
        }
    }
}