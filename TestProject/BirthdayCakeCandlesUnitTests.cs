using System;
using System.Runtime.InteropServices.WindowsRuntime;
using ConsoleApp;
using Xunit;

namespace TestProject
{
    public class BirthdayCakeCandlesUnitTests
    {
        [Fact]
        public void GivenOneCandleWhenCalculatingMaxThenItReturnsOne()
        {
            var candleHeights = new int[] { 1 };
            var result = BirthdayCakeCandles.birthdayCakeCandles(candleHeights);
            
            Assert.Equal(1, result);
        }

        [Fact]
        public void GivenZeroCandlesWhenCalculatingMaxThenItReturnsZero()
        {
            var candleHeights = new int[] { };
            var result = BirthdayCakeCandles.birthdayCakeCandles(candleHeights);
            
            Assert.Equal(0, result);
        }
        
        [Fact]
        public void GivenTwoCandlesWhenCalculatingMaxThenItReturnsTheNumberofCandlesWithMaxHeight1()
        {
            var candleHeights = new int[] { 2, 4 };
            var result = BirthdayCakeCandles.birthdayCakeCandles(candleHeights);
            
            Assert.Equal(1, result);
        }
        
        [Fact]
        public void GivenTwoCandlesWhenCalculatingMaxThenItReturnsTheNumberofCandlesWithMaxHeight2()
        {
            var candleHeights = new int[] { 4, 4 };
            var result = BirthdayCakeCandles.birthdayCakeCandles(candleHeights);
            
            Assert.Equal(2, result);
        }

        [Fact]
        public void GivenOneCandlesWhenCalculatingTheMaxItReturnsTheMaxCandleHeight()
        {
            var candleHeights = new int[] { 4 };
            var result = BirthdayCakeCandles.getMaxHeight(candleHeights);
            
            Assert.Equal(4, result);
        }
        
        [Fact]
        public void GivenOneCandlesWhenCalculatingTheMaxItReturnsTheMaxCandleHeight2()
        {
            var candleHeights = new int[] { 2 };
            var result = BirthdayCakeCandles.getMaxHeight(candleHeights);
            
            Assert.Equal(2, result);
        }
        
        [Fact]
        public void GivenTwoCandlesWhenCalculatingTheMaxItReturnsTheMaxCandleHeight()
        {
            var candleHeights = new int[] { 2, 4 };
            var result = BirthdayCakeCandles.getMaxHeight(candleHeights);
            
            Assert.Equal(4, result);
        }
        
        [Fact]
        public void GivenZeroCandlesWhenCalculatingTheMaxItReturnsZero()
        {
            var candleHeights = new int[] { };
            var result = BirthdayCakeCandles.getMaxHeight(candleHeights);
            
            Assert.Equal(0, result);
        }
        
        [Fact]
        public void GivenFiveCandlesWhenCalculatingTheMaxItReturnsZero()
        {
            var candleHeights = new int[] { 1, 2, 2, 3, 4, 1};
            var result = BirthdayCakeCandles.getMaxHeight(candleHeights);
            
            Assert.Equal(4, result);
        }
    }
}
