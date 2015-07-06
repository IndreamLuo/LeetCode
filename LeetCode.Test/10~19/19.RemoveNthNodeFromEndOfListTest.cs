using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Code;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class RemoveNthNodeFromEndOfListTest
    {
        RemoveNthNodeFromEndOfList removeNthNodeFromEndOfList = new RemoveNthNodeFromEndOfList();

        [TestMethod]
        public void RemoveNthFromEnd()
        {
            var listNodes = new List<LeetCode.Code.RemoveNthNodeFromEndOfList.ListNode>()
            {
                new LeetCode.Code.RemoveNthNodeFromEndOfList.ListNode(0)
            };
            for (var index = 1; index < 10; index++)
            {
                listNodes.Add(new RemoveNthNodeFromEndOfList.ListNode(index));
                listNodes[index - 1].next = listNodes[index];
            }

            Assert.AreEqual(removeNthNodeFromEndOfList
                .RemoveNthFromEnd(listNodes[0], 8)
                .next
                .next
                .val
                , listNodes[3]
                .val);

            Assert.AreEqual(removeNthNodeFromEndOfList
                .RemoveNthFromEnd(listNodes[0], 8)
                .next
                .next
                .val
                , listNodes[4]
                .val);

            Assert.AreEqual(removeNthNodeFromEndOfList
                .RemoveNthFromEnd(listNodes[0], 8)
                .val
                , listNodes[3]
                .val);

            Assert.AreEqual(removeNthNodeFromEndOfList
                .RemoveNthFromEnd(listNodes[0], 1)
                .next
                .next
                .next
                .next
                .next
                .next
                .val
                , listNodes[8]
                .val);
        }
    }
}
