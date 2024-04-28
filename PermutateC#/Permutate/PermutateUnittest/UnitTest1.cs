using Permutate;

namespace PermutateUnittest
{
    public class Tests
    {
        private PermutateClass _permutate { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _permutate = new PermutateClass();
        }

        [Test]
        public void Test1()
        {
            var input = "";
            var output = _permutate.AllPermutations(input);
            string[] expected = { "" };
            Assert.AreEqual(expected, output); 
        }

        [Test]
        public void Test2()
        {
            var input = "a";
            var output = _permutate.AllPermutations(input);
            string[] expected = { "a" };
            Assert.AreEqual(expected, output);
        }


        [Test]
        public void Test3()
        {
            var input = "ab";
            var output = _permutate.AllPermutations(input);
            string[] expected = { "ab", "ba" };
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void Test4()
        {
            var input = "abc";
            var output = _permutate.AllPermutations(input);
            string[] expected = { "abc", "acb", "bac", "bca", "cba", "cab" };
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void Test5()
        {
            var input = "aabb";
            var output = _permutate.AllPermutations(input);
            string[] expected = { "aabb", "abab", "abba", "baab", "baba", "bbaa" };
            Assert.AreEqual(expected, output);
        }
    }
}