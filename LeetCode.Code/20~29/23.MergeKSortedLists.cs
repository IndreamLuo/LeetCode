using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class MergeKSortedLists
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode MergeKLists(ListNode[] lists)
        {
            switch(lists.Length)
            {
                case 0:
                    return null;
                case 1:
                    return lists.First();
                default:
                    var newLists = new ListNode[(lists.Length + 1) / 2];
                    for (var index = 0; index < lists.Length; index += 2)
                    {
                        newLists[index / 2] = index == lists.Length - 1
                            ? lists[index]
                            : this.Merge2Lists(
                                lists[index]
                                , lists[index + 1]);
                    }
                    return this.MergeKLists(newLists);
            }
        }

        public ListNode Merge2Lists(ListNode first, ListNode second)
        {
            if (first == null)
                return second;

            if (second == null)
                return first;

            var result = new ListNode(0);
            var currentNode = result;

            while (first != null || second != null)
            {
                if (first == null)
                {
                    currentNode.next = second;
                    second = null;
                }
                else if (second == null)
                {
                    currentNode.next = first;
                    first = null;
                }
                else if (first.val <= second.val)
                {
                    currentNode.next = first;
                    first = first.next;
                }
                else
                {
                    currentNode.next = second;
                    second = second.next;
                }

                currentNode = currentNode.next;
            }

            return result.next;
        }
    }
}
