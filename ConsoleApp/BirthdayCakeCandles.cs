using System;
using System.Linq;

namespace ConsoleApp
{
    public class BirthdayCakeCandles
    {
        public static int birthdayCakeCandles(int[] ar)
        {
            if (ar.Length == 0) return 0;
            int maxHeight = getMaxHeight(ar);
            int counter = 0;
            foreach (int i in ar)
            {
                if (i == maxHeight)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static int getMaxHeight(int[] candleHeights)
        {
            if (candleHeights.Length == 0) return 0;
            return candleHeights.Max();
        }
    }
}
