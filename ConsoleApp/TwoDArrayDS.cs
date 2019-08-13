using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public static class TwoDArrayDS
    {
        public static int HourglassSum(int[][] arr)
        {
            var result = GetSums(arr);
            if (!result.Any()) return 0;
            return result.Max();
        }

        public static List<int> GetSums(int[][] arr)
        {
            var listOfSums = new List<int>();
            var rows = arr.GetLength(0);
            var smallerColumnCount = arr.Count(x => x.Length < 3);
            if (rows < 3 || smallerColumnCount > 0)
                return listOfSums;

            for (int row = 0; row < rows - 2; row++)
            {
                var columns = arr[row].Length;
                for (int column = 0; column < columns - 2; column++)
                {
                    AddHourglassSum(arr, listOfSums, row, column);
                }
            }
            return listOfSums;
        }

        private static void AddHourglassSum(int[][] arr, List<int> listOfSums, int row, int column)
        {
            var topLeft = arr[row][column];
            var topCenter = arr[row][column + 1];
            var topRight = arr[row][column + 2];
            var hourGlassCenter = arr[row + 1][column + 1];
            var bottomLeft = arr[row + 2][column];
            var bottomCenter = arr[row + 2][column + 1];
            var bottomRight = arr[row + 2][column + 2];

            var currentSum = topLeft + topCenter + topRight +
                                hourGlassCenter +
                                bottomLeft + bottomCenter + bottomRight;

            listOfSums.Add(currentSum);
        }
    }
}
