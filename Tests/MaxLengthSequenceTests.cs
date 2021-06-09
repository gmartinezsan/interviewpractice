using System.Collections.Generic;
using Solutions;
using Xunit;

namespace LinkedListsTests
{

    public class MaxLengthSequenceTests
    {
        [Fact]
        public void MaxLengthSequence()
        {
            List<string> arr = new List<string>();
            arr.AddRange(new string[] { "cha", "r", "act", "ers" });
            Assert.Equal(4, MaximumLengthOfConcatSeq.MaxLength(arr));
        }
    }
}