using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode.test
{
    [TestClass]
    public class LongestPalindromeTest
    {
        /*
         Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.

        Example:

        Input: "babad"

        Output: "bab"

        Note: "aba" is also a valid answer.
        Example:

        Input: "cbbd"

        Output: "bb"

             */
        [TestMethod]
        public void TestMethod1()
        {
            var str = LongestPalindrome("babad");
            var values = new[] { "bab", "aba" };

            Assert.IsTrue(values.Any(s => s == str));
        }
        [TestMethod]
        public void TestMethod2()
        {
            var str = LongestPalindrome("cbbd");
            Assert.AreEqual("bb", str);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var str = LongestPalindrome("abb");
            Assert.AreEqual("bb", str);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var str = LongestPalindrome("babaddtattarrattatddetartrateedredividerb");
            Assert.AreEqual("ddtattarrattatdd", str);
        }
        [TestMethod]
        public void TestMethod5()
        {
            var str = LongestPalindrome("ccc");
            Assert.AreEqual("ccc", str);
        }
        [TestMethod]
        public void TestMethod6()
        {
            var str = LongestPalindrome("bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb");
            Assert.AreEqual("bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb", str);
        }
        [TestMethod]
        public void TestMethod7()
        {
            var str = LongestPalindrome("cccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccc");
            Assert.AreEqual("cccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccc", str);
        }
        public string LongestPalindrome(string s)
        {
            var array = s.ToCharArray();
            var longestPalindrome = string.Empty;
            for (var i = 0; i < s.Length;)
            {
                var str = array[i].ToString();
                var j = i;
                while (++j < s.Length && array[i] == array[j])
                {
                    str += array[j];
                }

                var palindrome = GetPalindrome(str, array, i - 1, j);

                if (palindrome.Length > longestPalindrome.Length)
                    longestPalindrome = palindrome;
                i = j;
            }
            return longestPalindrome;
        }

        private string GetPalindrome(string s, char[] c, int i, int j)
        {
            while (true)
            {
                if (i < 0 || j == c.Count())
                    return s;
                if (c[i] != c[j])
                    return s;

                s = c[i] + s + c[j];
                i = --i;
                j = ++j;
            }
        }
        public string LongestPalindrome1(string s)
        {
            var array = s.ToCharArray();
            var longestPalindrome = string.Empty;
            for (var i = 0; i < s.Length; i++)
            {
                var str = array[i].ToString();
                var j = i;
                while (++j < s.Length && array[i] == array[j])
                {
                    str += array[j];
                }

                var palindrome = GetPalindrome(str, array, i - 1, j);

                if (palindrome.Length > longestPalindrome.Length)
                    longestPalindrome = palindrome;

                if (i + 1 == s.Length)
                    continue;

                if (array[i] != array[i + 1])
                    continue;
                str += array[i + 1];
                palindrome = GetPalindrome(str, array, i - 1, i + 2);

                if (palindrome.Length > longestPalindrome.Length)
                    longestPalindrome = palindrome;
            }
            return longestPalindrome;
        }

        public string LongestPalindrome2(string s)
        {
            var array = new[] { s };

            while (!array.Any(IsPalindrome))
            {
                array = array.SelectMany(a => new[] { a.Substring(1), a.Substring(0, a.Length - 1) }).ToArray();
            }
            return array.First(IsPalindrome);
        }
        public string LongestPalindrome3(string s)
        {
            if (string.IsNullOrEmpty(s))
                return null;

            if (IsPalindrome(s))
                return s;
            var a = LongestPalindrome3(s.Substring(1));
            var b = LongestPalindrome3(s.Substring(0, s.Length - 1));
            return a?.Length > b?.Length ? a : b;
        }

        private bool IsPalindrome(string s)
        {
            var array = s.ToCharArray();
            for (var i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - i - 1])
                    return false;
            }
            return true;
        }
    }
}
