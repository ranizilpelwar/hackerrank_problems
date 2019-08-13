using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class BonAppetit
    {

        public static string NO_REFUND_DUE = "Bon Appetit";
        
        public static void bonAppetit(List<int> bill, int k, int b) {

            Console.Write(VerifyCalculation(bill, k, b));
        }
        
        public static string VerifyCalculation(List<int> listOfItemPrices, int indexOfItemAnnaDidntEat, int amountAnnaPaid)
        {
            var split = GetSplit(listOfItemPrices, indexOfItemAnnaDidntEat);

            var difference = amountAnnaPaid - split;

            if (difference == 0)
            {
                return NO_REFUND_DUE;
            }

            return difference.ToString();
        }

        public static int GetSplit(List<int> listOfItemPrices, int indexOfItemAnnaDidntEat)
        {
            var length = listOfItemPrices.Count;
            var arrayOfPrices = new int[length];
            var index = 0;
            foreach (var price in listOfItemPrices)
            {
                arrayOfPrices[index] = price;
                index++;
            }

            arrayOfPrices[indexOfItemAnnaDidntEat] = 0;

            var sum = 0;
            
            foreach (var price in arrayOfPrices)
            {
                sum = sum + price;
            }
            return sum/2;
        }
        
    }
    
}