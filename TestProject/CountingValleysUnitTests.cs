using ConsoleApp;
using Xunit;

namespace TestProject
{
    public class CountingValleysUnitTests
    {
        [Fact]
        public void GivenNoStepsWereTaken_WhenCountingValleys_ThenZeroIsReturned()
        {
            Assert.Equal(0, Solutions.CountingValleys(0, ""));
        }
        
        [Fact]
        public void GivenStepsOnAMountainWereTaken_WhenCountingValleys_ThenZeroIsReturned()
        {
            Assert.Equal(0, Solutions.CountingValleys(4, "UUDD"));
        }
        
        [Fact]
        public void GivenIncompleteValleyStepsWereTaken_WhenCountingValleys_ThenZeroIsReturned()
        {
            Assert.Equal(0, Solutions.CountingValleys(3, "DDU"));
        }
        
        [Fact]
        public void GivenStepsOnAValleyWereTaken_WhenCountingValleys_ThenOneIsReturned()
        {
            Assert.Equal(1, Solutions.CountingValleys(4, "DDUU"));
        }
        
        [Fact]
        public void GivenExample_WhenCountingValleys_ThenOneIsReturned()
        {
            Assert.Equal(1, Solutions.CountingValleys(8, "UDDDUDUU"));
        }

        [Fact]
        public void GivenExample1_WhenCountingValleys_ThenTwoIsReturned()
        {
            Assert.Equal(2, Solutions.CountingValleys(12, "DDUUDDUDUUUD"));
        }
    }
}