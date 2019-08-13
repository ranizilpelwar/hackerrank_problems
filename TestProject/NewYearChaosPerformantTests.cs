using System.Collections.Generic;
using ConsoleApp;
using Xunit;

namespace TestProject
{
    public class NewYearChaosPerformantTests
    {
        //[Theory]
        [MemberData(nameof(GetIndexOfData))]
        public void IndexOfFirstBribe3_ReturnsExpectedResult(int[] queue, int expectedIndex)
        {
            var result = NewYearChaosPerformant.IndexOfFirstBribe(queue);

            Assert.Equal(expectedIndex, result);
        }

        public static IEnumerable<object[]> GetIndexOfData =>
            new List<object[]>
            {
                new object[] { new int[] {1, 2, 5, 3, 7, 8, 6, 4}, 3 },
                new object[] { new int[] {1, 2, 3, 5, 7, 8, 6, 4}, 7 },
                new object[] { new int[] {1, 2, 3, 4, 5, 7, 8, 6}, 7 },
                new object[] { new int[] {1, 2, 3, 4, 5, 6, 7, 8}, -1 }
            };
    }
}