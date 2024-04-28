
using Xunit;
using Smileface;
using System;
using System.Reflection;


namespace TestSmily

{
    public class SmilyTest
    {
        private SmilyFace _smilyFace { get; set; } = null;
        [Fact] 
        public void TestResult1()
        {
            var aaa = new _smilyFace;
            var input = new string[] { ";]", ":[", ";*", ":$", ";-D" };
            int output = aaa.
            var expected = 1;
            Assert.Equal(output, expected);
        }
        [Fact]
        public void TestResult2()
        {
            var input = new string[] { ":)", ";(", ";}", ":-D" };
            var output = SmileyCheck(input);
            var expected = 2;
            Assert.Equal(output, expected);
        }
        [Fact]
        public void TestResult3()
        {
            var input = new string[] { ":D", ":-(", ":-)", ";~)" };
            var output = SmileyCheck(input);
            var expected = 3;
            Assert.Equal(output, expected);
        }
    }
}