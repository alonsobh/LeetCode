using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode.test
{
    /*
     Given an array of integers, return indices of the two numbers such that they add up to a specific target.

    You may assume that each input would have exactly one solution, and you may not use the same element twice.

    Example:
    Given nums = [2, 7, 11, 15], target = 9,

    Because nums[0] + nums[1] = 2 + 7 = 9,
    return [0, 1].
         */

    [TestClass]
    public class TwoSumTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var array = new[] { 2, 7, 11, 15 };
            var result = TwoSum(array, 9);

            Assert.AreEqual(result[0], 0);
            Assert.AreEqual(result[1], 1);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var array = new[] { 3, 2, 4 };
            var result = TwoSum(array, 6);

            Assert.AreEqual(result[0], 1);
            Assert.AreEqual(result[1], 2);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var array = new[] { 3, 2, 3 };
            var result = TwoSum(array, 6);

            Assert.AreEqual(result[0], 0);
            Assert.AreEqual(result[1], 2);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var array = new[] { 0, 4, 3, 0 };
            var result = TwoSum(array, 0);

            Assert.AreEqual(result[0], 0);
            Assert.AreEqual(result[1], 3);
        }
        [TestMethod]
        public void TestMethod5()
        {
            var array = new[] { -1, -2, -3, -4, -5 };
            var result = TwoSum(array, -8);

            Assert.AreEqual(result[0], 2);
            Assert.AreEqual(result[1], 4);
        }

        public int[] TwoSum(int[] nums, int target)
        {
            var l = nums.Length;
            for (var i = 0; i < l; i++)
            {
                for (var j = i + 1; j < l; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new[] { i, j };
                }
            }
            return null;
        }
    }
}