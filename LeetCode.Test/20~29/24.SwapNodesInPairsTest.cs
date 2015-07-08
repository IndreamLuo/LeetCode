using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Code;

namespace LeetCode.Test
{
    [TestClass]
    public class SwapNodesInPairsTest
    {
        SwapNodesInPairs swapNodesInPairs = new SwapNodesInPairs();

        void AssertRight(LeetCode.Code.SwapNodesInPairs.ListNode list, int[] array)
        {
            var currentNode = list;
            var index = 0;
            while (currentNode != null)
            {
                if (index % 2 == 0)
                    if (index + 1 == array.Length)
                    {
                        Assert.AreEqual(array[index], currentNode.val);
                        currentNode = currentNode.next;
                    }
                    else
                        Assert.AreEqual(array[index], currentNode.next.val);
                else
                {
                    Assert.AreEqual(array[index], currentNode.val);
                    if (currentNode.next != null)
                        currentNode = currentNode.next.next;
                }

                index++;
            }
        }

        LeetCode.Code.SwapNodesInPairs.ListNode CreateList(int[] array)
        {
            var result = new LeetCode.Code.SwapNodesInPairs.ListNode(0);
            var currentNode = result;
            foreach (var item in array)
            {
                currentNode.next = new SwapNodesInPairs.ListNode(item);
                currentNode = currentNode.next;
            }

            return result.next;
        }

        [TestMethod]
        public void SwapPairs()
        {
            var arrayLength = 100;
            var array = new int[arrayLength];
            var list = new LeetCode.Code.SwapNodesInPairs.ListNode(0);
            var currentNode = list;
            for (var index = 0; index < arrayLength; index++)
                currentNode = currentNode.next = new SwapNodesInPairs.ListNode(array[index] = index);

            this.AssertRight(swapNodesInPairs.SwapPairs(list.next), array);
            this.AssertRight(null, new int[0]);
            this.AssertRight(new LeetCode.Code.SwapNodesInPairs.ListNode(0), new int[] { 0 });
        }
    }
}
