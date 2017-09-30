using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode.test
{
    [TestClass]
    public class ZigZagConversionTest
    {
        /*
        The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

P   A   H   N
A P L S I I G
Y   I   R
And then read line by line: "PAHNAPLSIIGYIR"
Write the code that will take a string and make this conversion given a number of rows:

string convert(string text, int nRows);
convert("PAYPALISHIRING", 3) should return "PAHNAPLSIIGYIR".
             */
        [TestMethod]
        public void TestMethod1()
        {
            var val = Convert("PAYPALISHIRING", 3);
            Assert.AreEqual(val, "PAHNAPLSIIGYIR");
        }
        [TestMethod]
        public void TestMethod2()
        {
            var val = Convert("AB", 1);
            Assert.AreEqual(val, "AB");
        }
        [TestMethod]
        public void TestMethod3()
        {
            var val = Convert("A", 1);
            Assert.AreEqual(val, "A");
        }

        public string Convert2(string s, int numRows)
        {
            if (numRows == 1)
                return s;
            if (s.Length <= numRows)
                return s;
            var w = string.Empty;
            var a = s.ToCharArray();
            for (var i = 0; i < numRows; i++)
            for (var j = i; j < s.Length; j += i)
                w += a[j];
            return w;
        }

        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
                return s;
            if (s.Length <= numRows)
                return s;

            var array = new string[numRows];
            var pos = 0;
            var op = 1;

            foreach (var c in s.ToCharArray())
            {
                array[pos] += c;
                if ((pos == 0 && op < 0)
                    ||(pos == numRows - 1))
                    op = op * -1;
                pos = pos + 1 * op;
            }

            return string.Join("", array);
        }
    }
}