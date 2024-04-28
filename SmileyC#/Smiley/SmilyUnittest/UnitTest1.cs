

using Smileface;

namespace SmilyTest.nUnitTest
{
    public class SmilyUnittest
    {
        private SmilyFaceFunction _smileface { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            _smileface = new SmilyFaceFunction();
        }

        [Test]
        public void TestResult1()
        {
            var input = new string[] { ";]", ":[", ";*", ":$", ";-D" };
            int output = _smileface.SmileyCheck(input);
            var expected = 1;
            Assert.That(expected, Is.EqualTo(output));
        }
        [Test]
        public void TestResult2()
        {
            var input = new string[] { ":)", ";(", ";}", ":-D" };
            int output = _smileface.SmileyCheck(input);
            var expected = 2;
            Assert.That(expected, Is.EqualTo(output));
        }
        [Test]
        public void TestResult3()
        {
            var input = new string[] { ":D", ":-(", ":-)", ";~)" };
            int output = _smileface.SmileyCheck(input);
            var expected = 3;
            Assert.That(expected, Is.EqualTo(output));
        }
    }
}