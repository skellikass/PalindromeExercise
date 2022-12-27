using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("mom", true)]
        [InlineData("dad", true)]
        [InlineData("dog", false)]
        [InlineData("pop", true)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            WordSmith challenger = new WordSmith();
            var actual = challenger.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
