using Xunit;

namespace TestProject {
    public class MergeSortedArraysTests {
        [Fact]
        public void GivenTwoArrays_ThenItReturnsOneSortedArray()
        {
        int[] myArray =     { 3, 4, 6, 10, 11, 15 };
        int[] alicesArray = { 1, 5, 8, 12, 14, 19 };
        int[] expected = {1, 3, 4, 5, 6, 8, 10, 11, 12, 14, 15, 19};

        var actual = merge(myArray, alicesArray);

        Assert.Equal(expected, actual);
        }

        private int[] merge(int[] leftArray, int[] rightArray)
        {
            int[] result = new int[leftArray.Length + rightArray.Length];
            var newArrayIndex = 0;
            var leftArrayIndex = 0;
            var rightArrayIndex = 0;
            while (leftArrayIndex < leftArray.Length) {
                if (leftArray[leftArrayIndex] < rightArray[rightArrayIndex]) {
                    result[newArrayIndex] = leftArray[leftArrayIndex];
                    leftArrayIndex++;
                }
                else {
                    result[newArrayIndex] = rightArray[rightArrayIndex];
                    rightArrayIndex++;
                }
                newArrayIndex++;
            }
            while (leftArrayIndex < leftArray.Length) {
                result[newArrayIndex] = leftArray[leftArrayIndex];
                leftArrayIndex++;
                newArrayIndex++;
            }
            while (rightArrayIndex < rightArray.Length) {
                result[newArrayIndex] = rightArray[rightArrayIndex];
                rightArrayIndex++;
                newArrayIndex++;
            }

            return result;
        }
    }
}