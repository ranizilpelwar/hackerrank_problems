using System;
using ConsoleApp;
using Xunit;

namespace TestProject
{
    public class RepeatedStringTests
    {
        [Theory]
        [InlineData("", 0, 0)]
        [InlineData("a", 1, 1)]
        [InlineData("s", 1, 0)]
        [InlineData("ssag", 3, 1)]
        [InlineData("ssag", 12, 3)]
        [InlineData("abcac", 10, 4)]
        [InlineData("aba", 10, 7)]
        [InlineData("a", 1000000000000, 1000000000000)]
        public void GivenValues_WhenRunningCode_ThenExpectedValueIsReturned(
            string s, long n, long expectedResult)
        {
            var actualResult = RepeatedStrings.RepeatedString(s, n);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}