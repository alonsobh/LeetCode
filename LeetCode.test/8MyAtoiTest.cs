using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace leetcode.test
{
    [TestClass]
    public class MyAtoiTest
    {
        /*
        Implement atoi to convert a string to an integer.

Hint: Carefully consider all possible input cases. If you want a challenge, please do not see below and ask yourself what are the possible input cases.

Notes: It is intended for this problem to be specified vaguely (ie, no given input specs). You are responsible to gather all the input requirements up front.

Update (2015-02-10):
The signature of the C++ function had been updated. If you still see your function signature accepts a const char * argument, please click the reload button  to reset your code definition.

spoilers alert... click to show requirements for atoi.

Requirements for atoi:
The function first discards as many whitespace characters as necessary until the first non-whitespace character is found. Then, starting from this character, takes an optional initial plus or minus sign followed by as many numerical digits as possible, and interprets them as a numerical value.

The string can contain additional characters after those that form the integral number, which are ignored and have no effect on the behavior of this function.

If the first sequence of non-whitespace characters in str is not a valid integral number, or if no such sequence exists because either str is empty or it contains only whitespace characters, no conversion is performed.

If no valid conversion could be performed, a zero value is returned. If the correct value is out of the range of representable values, INT_MAX (2147483647) or INT_MIN (-2147483648) is returned.
             */
        [TestMethod]
        public void TestMethod1()
        {
            var val = MyAtoi("123");
            Assert.AreEqual(val, 123);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var val = MyAtoi("  -0012a42");
            Assert.AreEqual(val, -12);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var val = MyAtoi("+1");
            Assert.AreEqual(val, 1);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var val = MyAtoi("+-1");
            Assert.AreEqual(val, 0);
        }
        [TestMethod]
        public void TestMethod5()
        {
            var val = MyAtoi("   +0 123");
            Assert.AreEqual(val, 0);
        }
        [TestMethod]
        public void TestMethod6()
        {
            var val = MyAtoi("2147483648");
            Assert.AreEqual(val, 2147483647);
        }

        public int MyAtoi(string str)
        {
            var s = string.Empty;
            foreach (var c in str.ToCharArray())
            {
                if (c == 32)
                {
                    if (string.IsNullOrEmpty(s))
                        continue;
                    break;
                }
                if (c == '-' || c == '+')
                {
                    if (s == "-" || s == "+")
                        return 0;
                    if (s.Length > 0)
                        break;
                }

                if (c != '-' && c != '+' && !(c > 47 && c < 58))
                    break;
                s += c;
            }
            if (string.IsNullOrEmpty(s) || s == "-" || s == "+")
                return 0;

            try
            {
                return int.Parse(s);
            }
            catch (OverflowException)
            {
                if (s.ToCharArray()[0] == '-')
                    return Int32.MinValue;
                return Int32.MaxValue;
            }
        }
    }
}
