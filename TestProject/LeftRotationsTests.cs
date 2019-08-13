using System;
using ConsoleApp;
using Xunit;

namespace TestProject
{
    public class LeftRotationsTests
    {
        [Fact]
        public void GivenArrayOfSizeZero_WhenRotatingLeft_ArrayOfSizeZeroIsReturned()
        {
            var result = LeftRotations.rotLeft(new int[0], 0);

            Assert.Empty(result);
        }

        [Fact]
        public void GivenZeroRotations_WhenRotatingLeft_SameArrayIsReturned()
        {
            var array = new int[] { 1, 2, 3 };

            var result = LeftRotations.rotLeft(array, 0);

            Assert.Equal(array, result);
        }

        [Fact]
        public void GivenOneRotation_WhenRotatingLeft_ExpectedArrayIsReturned()
        {
            var array = new int[] { 1, 2, 3 };
            var rotations = 1;
            var expectedResult = new int[] { 2, 3, 1 };

            var actualResult = LeftRotations.rotLeft(array, rotations);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
