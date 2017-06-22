using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode.test
{
    [TestClass]
    public class LengthOfLongestSubstringTest
    {
        /*
         Given a string, find the length of the longest substring without repeating characters.

        Examples:

        Given "abcabcbb", the answer is "abc", which the length is 3.

        Given "bbbbb", the answer is "b", with the length of 1.

        Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.

        Subscribe to see which companies asked this question.
             */
        [TestMethod]
        public void TestMethod1()
        {
            var val = LengthOfLongestSubstring("abcabcbb");
            Assert.AreEqual(val, 3);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var val = LengthOfLongestSubstring("bbbbb");
            Assert.AreEqual(val, 1);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var val = LengthOfLongestSubstring("pwwkew");
            Assert.AreEqual(val, 3);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var val = LengthOfLongestSubstring("etyyepfaesjlkzivdevdllygazxjndjrxhrdyyddqnqdoayshwxshxzjywu");
            Assert.AreEqual(val, 12);
        }

        public int LengthOfLongestSubstring(string s)
        {
            var maxLength = 0;
            var list = new List<char>();
            var array = s.ToCharArray();
            foreach (var c in array)
            {
                while (list.Any(i => i == c))
                {
                    list.RemoveAt(0);
                }
                list.Add(c);
                if (maxLength < list.Count)
                    maxLength = list.Count;
            }
            return maxLength;
        }

        public int LengthOfLongestSubstring2(string s)
        {
            var maxLength = 0;
            for (var i = 0; i < s.Length; i++)
            {
                for (var j = s.Length; j > i; j--)
                {
                    var sub = s.Substring(i, j - i);
                    if (sub.Length > maxLength && !HasDuplicate(sub))
                        maxLength = sub.Length;
                }
            }
            return maxLength;
        }

        private bool HasDuplicate(string sub)
        {
            var array = sub.ToCharArray();
            return array.GroupBy(c => c).Any(c => c.Count() > 1);
        }
    }
}
