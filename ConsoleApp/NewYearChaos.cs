using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public static class NewYearChaos
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
            var minimumNumberOfBribes = 0;
            if (queue.Length <= 1)
                return minimumNumberOfBribes;

            if (IsQueueTooChaotic(queue)) return TooChaotic;
       
            var index = IndexOfFirstBribe(queue);
            while (index >= 0)
            {
                queue = Swap(queue, index);
                minimumNumberOfBribes++;
                index = IndexOfFirstBribe(queue);
            }
            return minimumNumberOfBribes;
        }

        public static int IndexOfFirstBribe(int[] queue)
        {
            for (var index = 0; index < queue.Length - 1; index++)
            {
                var currentValue = queue[index];
                if (currentValue > index && currentValue > queue[index+1])
                    return index;               
            }
            return -1;
        }

        public static bool IsTooChaotic(int[] queue, int index)
        {
            return queue[index] - queue[index + 1] > 2;
        }

        public static int[] Swap(int[] queue, int index)
        {
            var newQueue = new int[queue.Length]; 
            queue.CopyTo(newQueue, 0);
            newQueue[index] = queue[index + 1];
            newQueue[index+1] = queue[index];
            return newQueue;
        }

        public static bool IsQueueTooChaotic(IEnumerable<int> queue)
        {
            return queue.Where((t, index) => t - 1 - index > 2).Any();
        }
    }
}
