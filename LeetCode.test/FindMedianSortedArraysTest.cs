using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode.test
{
    [TestClass]
    public class FindMedianSortedArraysTest
    {
        [TestMethod]
        public void TestMethodMethod1()
        {
            var nums1 = new[] { 1, 3 };
            var nums2 = new[] { 2 };
            var result = FindMedianSortedArrays(nums1, nums2);
            Assert.AreEqual(2.0, result);
        }
        [TestMethod]
        public void TestMethodMethod2()
        {
            var nums1 = new[] { 1, 2 };
            var nums2 = new[] { 3, 4 };
            var result = FindMedianSortedArrays(nums1, nums2);
            Assert.AreEqual(2.5, result);
        }
        [TestMethod]
        public void TestMethodMethod3()
        {
            var nums1 = new[] { 4, 5, 6, 8, 9 };
            var nums2 = new int[] { };
            var result = FindMedianSortedArrays(nums1, nums2);
            Assert.AreEqual(6, result);
        }
        [TestMethod]
        public void TestMethodMethod4()
        {
            var nums1 = new[] { 1, 1 };
            var nums2 = new[] { 1, 2 };
            var result = FindMedianSortedArrays(nums1, nums2);
            Assert.AreEqual(1, result);
        }
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var nums1List = nums1.ToList();
            nums1List.AddRange(nums2);
            var newArray = nums1List.ToArray();
            newArray = newArray.OrderBy(c => c).ToArray();
            var length = newArray.Count();
            var pos = length / 2;
            if (length % 2 == 0)
                return (newArray[pos] + newArray[pos - 1]) / 2.0;
            return newArray[pos];
        }
    }
}
