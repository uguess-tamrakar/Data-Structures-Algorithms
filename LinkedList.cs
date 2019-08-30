using System.Collections.Generic;

namespace Data_Structures___Algorithms
{
    public class LinkedList
    {
        public static ListNode ReverseList(ListNode head)
        {
            ListNode result = null;
            ReverseRecursive(head);
            return Reversed;
        }

        private static ListNode ReverseIterative(ListNode head)
        {
            ListNode result = null;

            while (head != null)
            {
                ListNode current = head.next;
                head.next = result;
                result = head;
                head = current;
            }

            return result;
        }

        private static ListNode Reversed;
        private static ListNode ReverseRecursive(ListNode head)
        {
            if (head != null && head.next != null)
            {
                ListNode Temp = ReverseRecursive(head.next);
                Temp.next = head;
                head.next = null;
            }
            else
            {
                Reversed = head;
            }

            return head;
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode result = null;

            while (l1 != null || l2 != null)
            {
                ListNode current;
                if (l1 != null && l2 != null)
                {
                    if (l1.val == l2.val)
                    {
                        current = new ListNode(l1.val);
                        current.next = new ListNode(l2.val);
                        l1 = l1?.next;
                        l2 = l2?.next;
                    }
                    else if (l1.val < l2.val)
                    {
                        current = new ListNode(l1.val);
                        l1 = l1.next;
                    }
                    else
                    {
                        current = new ListNode(l2.val);
                        l2 = l2.next;
                    }
                }
                else if (l1 == null)
                {
                    current = new ListNode(l2.val);
                    l2 = l2.next;
                }
                else
                {
                    current = new ListNode(l1.val);
                    l1 = l1.next;
                }

                if (result == null) result = current;
                else
                {
                    ListNode temp = result;
                    while (temp.next != null) temp = temp.next;
                    temp.next = current;
                }

            }

            return result;
        }

        public static ListNode MergeKLists(ListNode[] lists)
        {
            List<int> sortedVals = new List<int>();
            for (int i = 0; i < lists.Length; i++)
            {
                while (lists[i] != null)
                {
                    sortedVals.Add(lists[i].val);
                    lists[i] = lists[i].next;
                }
            }

            sortedVals.Sort();
            ListNode result = null;

            if (sortedVals.Count > 0)
            {
                result = new ListNode(sortedVals[0]);

                for (int i = 1; i < sortedVals.Count; i++)
                {
                    ListNode temp = new ListNode(sortedVals[i]);
                    ListNode head = result;
                    while (head.next != null) head = head.next;
                    head.next = temp;
                }

            }
            return result;
        }

        public static bool HasCycle(ListNode head)
        {
            bool result = false;

            if (head != null && head.next != null)
            {
                ListNode slow = head;
                ListNode fast = head.next;
                result = true;

                while (slow != fast)
                {
                    if (fast == null || fast.next == null)
                    {
                        result = false;
                        break;
                    }
                    slow = slow.next;
                    fast = fast.next.next;
                }
            }

            return result;
        }

    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}