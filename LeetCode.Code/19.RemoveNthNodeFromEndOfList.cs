using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class RemoveNthNodeFromEndOfList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int currentIndex;
            return this
                .RemoveNthFromEnd(head, n, out currentIndex);
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n, out int currentIndex)
        {
            if (head.next != null)
            {
                head.next = this.RemoveNthFromEnd(head.next, n, out currentIndex);
                currentIndex++;
            }
            else
                currentIndex = 1;

            if (currentIndex == n)
                return head.next;

            return head;
        }
    }
}
