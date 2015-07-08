using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class ReverseNodesInKGroup
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (k <= 1)
                return head;

            var currentNode = head;
            ListNode result = null;
            var reverseEnd = currentNode;

            for (var index = 1
                ; index < k
                && reverseEnd != null
                ; index++)
                reverseEnd = reverseEnd.next;

            result = reverseEnd ?? head;

            ListNode lastEnd = null;
            ListNode next = null;
            ListNode last, swap;
            while (currentNode != null)
            {
                reverseEnd = currentNode;

                for (var index = 1
                    ; index < k
                    && reverseEnd != null
                    ; index++)
                    reverseEnd = reverseEnd.next;

                if (lastEnd != null)
                    lastEnd.next = reverseEnd ?? currentNode;
                lastEnd = currentNode;

                if (reverseEnd != null)
                {
                    last = currentNode;
                    next = last.next;

                    lastEnd.next = null;
                    currentNode = reverseEnd.next;

                    while(next != currentNode)
                    {
                        swap = next.next;
                        next.next = last;
                        last = next;
                        next = swap;
                    }
                }
                else
                    currentNode = null;
            }

            return result;
        }
    }
}
