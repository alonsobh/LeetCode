using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode.test
{
    [TestClass]
    public class AddTwoNumbersTest
    {
        /*
         You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

        You may assume the two numbers do not contain any leading zero, except the number 0 itself.

        Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        Output: 7 -> 0 -> 8
        */

        [TestMethod]
        public void TestMethod1()
        {
            ListNode l1 = new ListNode(2) { next = new ListNode(4) { next = new ListNode(3) } };
            ListNode l2 = new ListNode(5) { next = new ListNode(6) { next = new ListNode(4) } };
            var result = AddTwoNumbers(l1, l2);

            Assert.AreEqual(result.val, 7);
            Assert.AreEqual(result.next.val, 0);
            Assert.AreEqual(result.next.next.val, 8);
            Assert.IsNull(result.next.next.next);
        }

        [TestMethod]
        public void TestMethod2()
        {
            ListNode l1 = new ListNode(1) { next = new ListNode(8) };
            ListNode l2 = new ListNode(0);
            var result = AddTwoNumbers(l1, l2);

            Assert.AreEqual(result.val, 1);
            Assert.AreEqual(result.next.val, 8);
            Assert.IsNull(result.next.next);
        }

        [TestMethod]
        public void TestMethod3()
        {
            ListNode l1 = new ListNode(5);
            ListNode l2 = new ListNode(5);
            var result = AddTwoNumbers(l1, l2);

            Assert.AreEqual(result.val, 0);
            Assert.AreEqual(result.next.val, 1);
            Assert.IsNull(result.next.next);
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return AddTwoNumbersTMP(l1, l2, 0);
        }
        public ListNode AddTwoNumbersTMP(ListNode l1, ListNode l2, int aditional)
        {
            var value = l1.val + l2.val + aditional;
            var result = new ListNode(value % 10);

            if (l1.next == null && l2.next == null)
            {
                if (value > 9)
                    result.next = new ListNode(1);
                return result;
            }
            result.next = AddTwoNumbersTMP(l1.next?? new ListNode(0), l2.next ?? new ListNode(0), value / 10);
            return result;
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}