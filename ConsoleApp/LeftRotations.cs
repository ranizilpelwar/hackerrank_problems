using System;
namespace ConsoleApp
{
    public static class LeftRotations
    {
        public static int[] rotLeft(int[] a, int d)
        {
            if (a.Length == 0 || d == 0)
                return a;

            var result = new int[a.Length];

            var indexOfNewArray = 0;
            for(int index = d; index < a.Length; index++)
            {
                result[indexOfNewArray] = a[index];
                indexOfNewArray++;
            }
            for (int index = 0; index < d; index++)
            {
                result[indexOfNewArray] = a[index];
                indexOfNewArray++;
            }
            return result;
        }
    }
}
