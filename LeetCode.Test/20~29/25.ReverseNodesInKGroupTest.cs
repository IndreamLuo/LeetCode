using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Code;

namespace LeetCode.Test
{
    [TestClass]
    public class ReverseNodesInKGroupTest
    {
        ReverseNodesInKGroup reverseNodesInKGroup = new ReverseNodesInKGroup();

        void AssertRight(LeetCode.Code.ReverseNodesInKGroup.ListNode list, int[] array)
        {
            var currentNode = list;
            foreach (var item in array)
            {
                Assert.AreEqual(item, currentNode.val);
                currentNode = currentNode.next;
            }

            Assert.IsNull(currentNode);
        }

        [TestMethod]
        public void ReverseKGroup()
        {
            var list = new LeetCode.Code.ReverseNodesInKGroup.ListNode(-1);
            var currentNode = list;
            var arrayLength = 100;
            var array = new int[arrayLength];
            for (var index = 0; index < arrayLength; index++)
                currentNode = currentNode.next = new ReverseNodesInKGroup.ListNode(array[index] = index);

            var k = 4;
            for (var index = 0
                ; index < arrayLength
                && index + k <= arrayLength
                ; index += k)
                for (var subIndex = index; subIndex < index + k / 2; subIndex++)
                {
                    var swap = array[subIndex];
                    array[subIndex] = array[index + k - (subIndex - index + 1)];
                    array[index + k - (subIndex - index + 1)] = swap;
                }

            this.AssertRight(reverseNodesInKGroup.ReverseKGroup(list.next, k), array);
            this.AssertRight(reverseNodesInKGroup.ReverseKGroup(null, 1), new int[] { });
            this.AssertRight(reverseNodesInKGroup.ReverseKGroup(new LeetCode.Code.ReverseNodesInKGroup.ListNode(0), 1), new int[] { 0 });
            this.AssertRight(reverseNodesInKGroup.ReverseKGroup(new LeetCode.Code.ReverseNodesInKGroup.ListNode(0), 2), new int[] { 0 });
            this.AssertRight(reverseNodesInKGroup.ReverseKGroup(new LeetCode.Code.ReverseNodesInKGroup.ListNode(1)
                    {
                        next = new ReverseNodesInKGroup.ListNode(2)
                    }
                    , 3)
                , new int[] { 1, 2 });
            this.AssertRight(reverseNodesInKGroup.ReverseKGroup(new LeetCode.Code.ReverseNodesInKGroup.ListNode(1)
                    {
                        next = new ReverseNodesInKGroup.ListNode(2)
                    }
                    , 1)
                , new int[] { 1, 2 });
        }
    }
}
