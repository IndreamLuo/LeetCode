using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Code;

namespace LeetCode.Test
{
    [TestClass]
    public class MergeTwoSortedListsTest
    {
        MergeTwoSortedLists mergeTwoSortedLists = new MergeTwoSortedLists();

        [TestMethod]
        public void MergeTwoLists()
        {
            var firstNode = new LeetCode.Code.MergeTwoSortedLists.ListNode(1);
            var currentNode = firstNode;
            for (var index = 3; index < 10; index += 2)
                currentNode =
                    currentNode.next = new MergeTwoSortedLists.ListNode(index);

            var secondNode = new LeetCode.Code.MergeTwoSortedLists.ListNode(2);
            currentNode = secondNode;
            for (var index = 4; index < 11; index += 2)
                currentNode =
                    currentNode.next = new MergeTwoSortedLists.ListNode(index);

            Assert.AreEqual(mergeTwoSortedLists.MergeTwoLists(firstNode, secondNode)
                , firstNode);
            Assert.AreEqual(firstNode.next, secondNode);
            Assert.AreEqual(mergeTwoSortedLists
                .MergeTwoLists(new MergeTwoSortedLists.ListNode(1)
                    , new MergeTwoSortedLists.ListNode(1)).next.val
                , 1);
        }
    }
}
