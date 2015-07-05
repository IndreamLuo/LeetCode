using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class SwapNodesInPairs
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode SwapPairs(ListNode head)
        {
            var currentNode = head;
            head = head == null
                ? head
                : head.next ?? head;
            ListNode next;
            while (currentNode != null
                && currentNode.next != null)
            {
                next = currentNode.next.next;
                currentNode.next.next = currentNode;
                currentNode.next = next == null
                    ? next
                    : next.next ?? next;

                currentNode = next;
            }

            return head;
        }
    }
}
