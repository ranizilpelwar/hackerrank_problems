using ConsoleApp;
using Xunit;

namespace TestProject
{
    public class SockMerchantUnitTests
    {
        [Fact]
        public void GivenZeroSocks_WhenCalculatingNumberOfMatchingPairs_ThenItReturnsZero()
        {
            var result = Solutions.SockMerchant(0, new int[0]);

            Assert.Equal(0, result);
        }
        
        [Fact]
        public void GivenOneSock_WhenCalculatingNumberOfMatchingPairs_ThenItReturnsZero()
        {
            var result = Solutions.SockMerchant(1, new[] { 1 });

            Assert.Equal(0, result);
        }
        
        [Fact]
        public void GivenTwoDifferentSocks_WhenCalculatingNumberOfMatchingPairs_ThenItReturnsZero()
        {
            var result = Solutions.SockMerchant(1, new[] { 1, 2 });

            Assert.Equal(0, result);
        }
        
        [Fact]
        public void GivenTwoSameColoredSocks_WhenCalculatingNumberOfMatchingPairs_ThenItReturnsOne()
        {
            var result = Solutions.SockMerchant(2, new[] { 1, 1 });

            Assert.Equal(1, result);
        }
        
        [Fact]
        public void Given3SocksWithOnePair_WhenCalculatingNumberOfMatchingPairs_ThenItReturnsOne()
        {
            var result = Solutions.SockMerchant(3, new[] { 1, 1, 2 });

            Assert.Equal(1, result);
        }
        
        [Fact]
        public void Given4SocksWithTwoPairs_WhenCalculatingNumberOfMatchingPairs_ThenItReturnsTwo()
        {
            var result = Solutions.SockMerchant(4, new[] { 1, 1, 2, 2 });

            Assert.Equal(2, result);
        }
        
        [Fact]
        public void Given4RearrangedSocksWithTwoPairs_WhenCalculatingNumberOfMatchingPairs_ThenItReturnsTwo()
        {
            var result = Solutions.SockMerchant(4, new[] { 2, 1, 2, 1 });

            Assert.Equal(2, result);
        }
        
        [Fact]
        public void GivenExample_WhenCalculatingNumberOfMatchingPairs_ThenItReturnsTwo()
        {
            var result = Solutions.SockMerchant(7, new[] { 1,2,1,2,1,3,2 });

            Assert.Equal(2, result);
        }
    }
}