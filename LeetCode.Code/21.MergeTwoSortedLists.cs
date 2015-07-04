using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class MergeTwoSortedLists
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            else if (l2 == null)
                return l1;

            if (l1.val <= l2.val)
                l1.next = this.MergeTwoLists(l1.next, l2);
            else
                l1 = this.MergeTwoLists(l2, l1);

            return l1;
        }
    }
}
