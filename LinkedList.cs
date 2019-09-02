using System.Collections.Generic;

namespace Data_Structures___Algorithms
{
    public class LinkedList
    {
        // Add two reversed linked lists
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            // ListNode result = new ListNode(0);
            // ListNode dummy = result;
            // int carry = 0;
            // while (l1 != null || l2 != null)
            // {
            //     int x = l1 != null ? l1.val : 0;
            //     int y = l2 != null ? l2.val : 0;
            //     int sum = carry + x + y;
            //     carry = sum / 10;
            //     dummy.next = new ListNode(sum % 10);
            //     dummy = dummy.next;
            //     if (l1 != null) l1 = l1.next;
            //     if (l2 != null) l2 = l2.next;
            // }

            // if (carry > 0) dummy.next = new ListNode(carry);
            // return result.next;
            return AddTwoNumbersRecursive(l1, l2, 0);
        }

        private ListNode AddTwoNumbersRecursive(ListNode l1, ListNode l2, int carry)
        {
            int sum = carry + l1.val + l2.val;
            carry = sum / 10;
            ListNode result = new ListNode(sum % 10);

            if (l1.next != null || l2.next != null)
            {
                l1 = l1.next == null ? new ListNode(0) : l1.next;
                l2 = l2.next == null ? new ListNode(0) : l2.next;
                result.next = AddTwoNumbersRecursive(l1, l2, carry);
            }
            else
            {
                if (carry > 0) result.next = new ListNode(carry);
            }

            return result;
        }

        public static ListNode ListNodeFromArray(int[] array)
        {
            ListNode result = new ListNode(0);
            ListNode current;
            ListNode temp;
            int index = 0;
            while (index < array.Length)
            {
                current = new ListNode(array[index]);
                temp = result;
                while (temp.next != null) temp = temp.next;
                temp.next = current;
                index++;
            }
            return result.next;
        }

        public static ListNode ReverseList(ListNode head)
        {
            //ListNode result = null;
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