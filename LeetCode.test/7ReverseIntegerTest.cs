using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace leetcode.test
{
    [TestClass]
    public class ReverseIntegerTest
    {
        /*
        Reverse digits of an integer.

        Example1: x = 123, return 321
        Example2: x = -123, return -321

        click to show spoilers.

        Have you thought about this?
        Here are some good questions to ask before coding. Bonus points for you if you have already thought through this!

        If the integer's last digit is 0, what should the output be? ie, cases such as 10, 100.

        Did you notice that the reversed integer might overflow? Assume the input is a 32-bit integer, then the reverse of 1000000003 overflows. How should you handle such cases?

        For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.

        Note:
        The input is assumed to be a 32-bit signed integer. Your function should return 0 when the reversed integer overflows.
             */
        [TestMethod]
        public void TestMethod1()
        {
            var val = Reverse(123);
            Assert.AreEqual(val, 321);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var val = Reverse(-123);
            Assert.AreEqual(val, -321);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var val = Reverse(1534236469);
            Assert.AreEqual(val, 0);
        }

        public int Reverse(int x)
        {
            var reverse = 0;
            var isNegative = x < 0;
            if (isNegative)
                x = x * -1;
            while (x > 0)
            {
                if (reverse > Int32.MaxValue / 10)
                    return 0;
                reverse = reverse * 10 + x % 10;
                x = x / 10;
            }

            if (isNegative)
                return reverse * -1;
            return reverse;
        }
    }
}
