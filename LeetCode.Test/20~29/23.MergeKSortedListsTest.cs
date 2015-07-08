using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LeetCode.Code;

namespace LeetCode.Test
{
    [TestClass]
    public class MergeKSortedListsTest
    {
        MergeKSortedLists mergeKSortedLists = new MergeKSortedLists();

        void AssertOrdered(LeetCode.Code.MergeKSortedLists.ListNode list, int count)
        {
            var nodeCount = 1;
            var currentListNode = list;

            while (currentListNode.next != null)
            {
                Assert.IsTrue(currentListNode.next.val >= currentListNode.val);
                currentListNode = currentListNode.next;
                nodeCount++;
            }

            Assert.AreEqual(count, nodeCount);
        }

        [TestMethod]
        public void MergeKLists()
        {
            var lists = new List<LeetCode.Code.MergeKSortedLists.ListNode>();
            var gap = 5;
            var eachCount = 10;
            var randomDifference = 3;
            var random = new Random(Guid.NewGuid().GetHashCode());
            var count = gap;
            for (var currentStart = 1
                ; currentStart <= gap
                ; currentStart++)
            {
                var firstNode = new LeetCode.Code.MergeKSortedLists.ListNode(currentStart);
                lists.Add(firstNode);

                for (var index = currentStart + gap
                    ; index <= gap * (eachCount + random.Next(-randomDifference, randomDifference))
                    ; index += gap)
                {
                    firstNode.next = new Code.MergeKSortedLists.ListNode(index);
                    firstNode = firstNode.next;
                    count++;
                }
            }

            this.AssertOrdered(mergeKSortedLists.MergeKLists(lists.ToArray()), count);

            lists = new List<MergeKSortedLists.ListNode>();
            var randomCount = 10000;
            for (var index = 0; index < randomCount; index++)
                lists.Add(new LeetCode.Code.MergeKSortedLists.ListNode(random.Next(int.MaxValue)));

            this.AssertOrdered(mergeKSortedLists.MergeKLists(lists.ToArray()), randomCount);
        }
    }
}
