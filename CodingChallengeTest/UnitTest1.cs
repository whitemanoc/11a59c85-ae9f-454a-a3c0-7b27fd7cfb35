using System;
using Xunit;
using CodingChallenge; 

namespace CodingChallengeTest
{
    public class UnitTest1
    {
        Program method = new Program();

        [Fact]
        public void TestCase01()
        {
            string input = "6 1 5 9 2";
            string output = method.FindSequence(input);
            string expectedOutput = "1 5 9";

            Assert.Equal(expectedOutput, output);
        }
    }
}
