using System.Collections.Generic;
using Solutions;
using Xunit;

namespace Tests
{
    public class PermutationsTests
    {


        [Fact]
        public void GetUniqueChars()
        {
            Assert.Equal(4, StringPermutations.GetUniqueChars("holl"));
        }


        [Fact]
        public void GetPermutations()
        {
            var expected = new List<string>();
            expected.AddRange(new string[] { "abc", "acb", "bac", "bca", "cba", "cab" });
            var actual = StringPermutations.AllPermutations("abc");
            // the sorting is only needed for the tests
            // to make both lists equal
            expected.Sort();
            actual.Sort();
            Assert.Equal(expected, actual);
        }
    }

}