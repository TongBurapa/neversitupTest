using OddAppear;

namespace OddAppearUnittest
{
    public class Tests
    {
        private OddAppearClass _oddAppear { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            _oddAppear = new OddAppearClass();
        }

        [Test]
        public void Test1()
        {
            int[] input = {7};
            var output = _oddAppear.FindOddAppear(input);
            int expected = 7;
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void Test2()
        {
            int[] input = { 0 };
            var output = _oddAppear.FindOddAppear(input);
            int expected = 0;
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void Test3()
        {
            int[] input = { 1,1,2 };
            var output = _oddAppear.FindOddAppear(input);
            int expected = 2;
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void Test4()
        {
            int[] input = { 0, 1, 0, 1, 0 };
            var output = _oddAppear.FindOddAppear(input);
            int expected = 0;
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void Test5()
        {
            int[] input = { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 };
            var output = _oddAppear.FindOddAppear(input);
            int expected = 4;
            Assert.AreEqual(expected, output);
        }

    }
}