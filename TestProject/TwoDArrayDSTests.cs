using System;
using System.Collections.Generic;
using ConsoleApp;
using Xunit;

namespace TestProject
{
    public class TwoDArrayDSTests
    {
        [Fact]
        public void Given6by6ArrayOfZeros_WhenCalculatingHourglassSum_ThenExpectedResultIsReturned()
        {
            var array = new int[6][];
            array[0] = new int[] { 0, 0, 0, 0, 0, 0};
            array[1] = new int[] { 0, 0, 0, 0, 0, 0 };
            array[2] = new int[] { 0, 0, 0, 0, 0, 0 };
            array[3] = new int[] { 0, 0, 0, 0, 0, 0 };
            array[4] = new int[] { 0, 0, 0, 0, 0, 0 };
            array[5] = new int[] { 0, 0, 0, 0, 0, 0 };

            var result = TwoDArrayDS.HourglassSum(array);
            Assert.Equal(0, result);
        }

        [Fact]
        public void GivenColumnsSmallerThanHourglassArray_WhenCalculatingHourglassSum_ThenExpectedResultIsReturned()
        {
            var array = new int[6][];
            array[0] = new int[] { 0, 0};
            array[1] = new int[] { 0, 0, 0, 0, 0, 0 };
            array[2] = new int[] { 0, 0, 0, 0, 0, 0 };
            array[3] = new int[] { 0, 0, 0, 0, 0, 0 };
            array[4] = new int[] { 0, 0, 0, 0, 0, 0 };
            array[5] = new int[] { 0, 0, 0, 0, 0, 0 };

            var result = TwoDArrayDS.HourglassSum(array);
            Assert.Equal(0, result);
        }

        [Fact]
        public void GivenSample1_WhenCalculatingHourglassSum_ThenExpectedResultIsReturned()
        {
            var array = new int[6][];
            array[0] = new int[] { -9, -9, -9, 1, 1, 1 };
            array[1] = new int[] { 0, -9, 0, 4, 3, 2 };
            array[2] = new int[] { -9, -9, -9, 1, 2, 3 };
            array[3] = new int[] { 0, 0, 8, 6, 6, 0 };
            array[4] = new int[] { 0, 0, 0, -2, 0, 0 };
            array[5] = new int[] { 0, 0, 1, 2, 4, 0 };

            var result = TwoDArrayDS.HourglassSum(array);

            var expectedSums = new List<int> { -63, -34, -9, 12,
                                                                             -10, 0, 28, 23,
                                                                             -27, -11, -2, 10,
                                                                             9, 17, 25, 18};

            var actualSums = TwoDArrayDS.GetSums(array);
            foreach(var sum in expectedSums)
            {
                Assert.True(actualSums.Contains(sum), $"Sum of '{ sum }' not found");
            }
            Assert.Equal(28, result);
        }

        [Fact]
        public void GivenSample2_WhenCalculatingHourglassSum_ThenExpectedResultIsReturned()
        {
            var array = new int[6][];
            array[0] = new int[] { 1, 1, 1, 0, 0, 0 };
            array[1] = new int[] { 0, 1, 0, 0, 0, 0 };
            array[2] = new int[] { 1, 1, 1, 0, 0, 0 };
            array[3] = new int[] { 0, 0, 2, 4, 4, 0 };
            array[4] = new int[] { 0, 0, 0, 2, 0, 0 };
            array[5] = new int[] { 0, 0, 1, 2, 4, 0 };

            var result = TwoDArrayDS.HourglassSum(array);

            Assert.Equal(19, result);
        }
    }
}
