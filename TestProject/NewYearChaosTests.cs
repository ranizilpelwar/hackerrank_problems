using System;
using System.Collections.Generic;
using Xunit;
using ConsoleApp;

namespace TestProject
{
    public class NewYearChaosTests
    {
        [Fact]
        public void GivenEmptyQueue_WhenGettingMinimumBribes_ThenItReturnsZero()
        {
            var result = NewYearChaos.GetMinimumBribes(new int[0]);

            Assert.Equal(0, result);
        }

        [Fact]
        public void GivenSingleQueue_WhenGettingMinimumBribes_ThenItReturnsZero()
        {
            var result = NewYearChaos.GetMinimumBribes(new int[1] {1});

            Assert.Equal(0, result);
        }

        [Fact]
        public void GivenBribeIsGreaterThanTwo_WhenGettingMinimumBribes_ThenItReturnsNegOne()
        {
            var queue = new int[] {2, 5, 1};
            var result = NewYearChaos.GetMinimumBribes(queue);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void GivenOneBribe_WhenGettingMinimumBribes_ThenItReturnsOne()
        {
            var queue = new int[] {2, 1};
            var result = NewYearChaos.GetMinimumBribes(queue);

            Assert.Equal(1, result);
        }

        [Fact]
        public void GivenSampleOne_WhenGettingMinimumBribes_ThenItReturnsExpectedValue()
        {
            var queue = new int[] {2, 1, 5, 3, 4};
            var result = NewYearChaos.GetMinimumBribes(queue);

            Assert.Equal(3, result);
        }

        [Fact]
        public void GivenSampleTwo_WhenGettingMinimumBribes_ThenItReturnsExpectedValue()
        {
            var queue = new int[] {2, 5, 1, 3, 4};
            var result = NewYearChaos.GetMinimumBribes(queue);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void GivenTestCaseOne1_WhenGettingMinimumBribes_ThenItReturnsExpectedValue()
        {
            var queue = new int[] {5, 1, 2, 3, 7, 8, 6, 4};
            var result = NewYearChaos.GetMinimumBribes(queue);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void GivenTestCaseOne2_WhenGettingMinimumBribes_ThenItReturnsExpectedValue()
        {
            var queue = new int[] {1, 2, 5, 3, 7, 8, 6, 4};
            var result = NewYearChaos.GetMinimumBribes(queue);

            Assert.Equal(7, result);
        }

        [Fact]
        public void Swap_ReturnsExpectedResult()
        {
            var queue = new int[] {2, 1};
            var expectedResult = new int[] {1, 2};

            var result = NewYearChaos.Swap(queue, 0);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void IsTooChaotic_ReturnsExpectedResult()
        {
            var queue = new int[] {5, 1};

            var result = NewYearChaos.IsTooChaotic(queue, 0);

            Assert.True(result);
        }

        [Fact]
        public void IndexOfFirstBribe1_ReturnsExpectedResult()
        {
            var queue = new int[] {5, 1};

            var result = NewYearChaos.IndexOfFirstBribe(queue);

            Assert.Equal(0, result);
        }

        [Fact]
        public void IndexOfFirstBribe2_ReturnsExpectedResult()
        {
            var queue = new int[] {1, 2, 4, 3};

            var result = NewYearChaos.IndexOfFirstBribe(queue);

            Assert.Equal(2, result);
        }

        [Theory]
        [MemberData(nameof(GetIndexOfData))]
        public void IndexOfFirstBribe3_ReturnsExpectedResult(int[] queue, int expectedIndex)
        {
            var result = NewYearChaos.IndexOfFirstBribe(queue);

            Assert.Equal(expectedIndex, result);
        }

        public static IEnumerable<object[]> GetIndexOfData =>
            new List<object[]>
            {
                new object[] { new int[] {1, 2, 5, 3, 7, 8, 6, 4}, 2 },
                new object[] { new int[] {1, 2, 3, 5, 7, 8, 6, 4}, 5 },
                new object[] { new int[] {1, 2, 3, 5, 7, 6, 8, 4}, 4 },
                new object[] { new int[] {1, 2, 3, 5, 6, 7, 8, 4}, 6 },
                new object[] { new int[] {1, 2, 3, 5, 6, 7, 4, 8}, 5 },
                new object[] { new int[] {1, 2, 3, 5, 6, 4, 7, 8}, 4 },
                new object[] { new int[] {1, 2, 3, 5, 4, 6, 7, 8}, 3 },
                new object[] { new int[] {1, 2, 3, 4, 5, 6, 7, 8}, -1 },
            };

        
        [Fact]
        public void IndexOfFirstBribe4_ReturnsExpectedResult()
        {
            var queue = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            var result = NewYearChaos.IndexOfFirstBribe(queue);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void IsQueueTooChaotic_ReturnsExpectedResult()
        {
            var queue = new int[] { 1, 2, 3, 5, 6, 7, 8, 4 };

            var result = NewYearChaos.IsQueueTooChaotic(queue);

            Assert.False(result);
        }

        [Fact]
        public void IsQueueTooChaotic2_ReturnsExpectedResult()
        {
            var queue = new int[] { 5, 1 };

            var result = NewYearChaos.IsQueueTooChaotic(queue);

            Assert.True(result);
        }
        
        [Fact]
        public void IsQueueTooChaotic3_ReturnsExpectedResult()
        {
            var queue = new int[] { 2, 1, 5, 3, 4 };

            var result = NewYearChaos.IsQueueTooChaotic(queue);

            Assert.False(result);
        }
    }
}
