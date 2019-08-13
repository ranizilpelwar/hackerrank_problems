using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public static class Solutions
    {
        public static int SockMerchant(int n, int[] ar)
        {
            int numberOfMatchingPairsOfSocks = 0;
            var list = ar.ToList();
            if (!list.Any()) return numberOfMatchingPairsOfSocks;
            do
            {
                var currentColor = list.First();
                list.Remove(currentColor);
                var match = list.FirstOrDefault(x => x == currentColor);
                if (match != 0)
                {
                    numberOfMatchingPairsOfSocks++;
                    list.Remove(match);
                }
            } while (list.Count > 1);
            return numberOfMatchingPairsOfSocks;
        }
        
        public static int CountingValleys(int n, string s)
        {
            var numberOfCompletedValleys = 0;
            if (string.IsNullOrEmpty(s)) return numberOfCompletedValleys;
            var accumulator = 0;
            var isValleyStart = false;
            foreach (var step in s)
            {
                if (accumulator == 0 && step.Equals('D')) 
                    isValleyStart = true;
                if (step.Equals('U')) accumulator++;
                if (step.Equals('D')) accumulator--;
                if (accumulator == 0 && isValleyStart)
                {
                    numberOfCompletedValleys++;
                    isValleyStart = false;
                }
            }
            return numberOfCompletedValleys;
        }
    }
}
