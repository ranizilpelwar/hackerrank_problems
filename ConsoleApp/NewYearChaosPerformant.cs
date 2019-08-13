using System;

namespace ConsoleApp
{
    public class NewYearChaosPerformant
    {
        static int TooChaotic => -1;

        public static void minimumBribes(int[] q)
        {
            var result = GetMinimumBribes(q);
            if (result == TooChaotic)
                Console.WriteLine("Too chaotic");
            else
                Console.WriteLine(result);
        }

        public static int GetMinimumBribes(int[] queue)
        {
            return 0;
        }


        public static int IndexOfFirstBribe(int[] queue)
        {
            for (var index = 1; index < queue.Length; index++)
            {
                var currentValue = queue[index];
                var isInWrongPlace = currentValue - index != 1;
                var canShiftLeft = currentValue < queue[index - 1];
                if (isInWrongPlace && canShiftLeft)
                    return index;               
            }
            return -1;
        }
    }
}