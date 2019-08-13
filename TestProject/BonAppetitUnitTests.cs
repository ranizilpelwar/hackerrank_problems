using System.Collections.Generic;
using ConsoleApp;
using Xunit;

namespace TestProject
{
    public class BonAppetitUnitTests
    {
        [Theory]
        [MemberData(nameof(ItemizedBillData))]
        public void GivenAppetizers_WhenAnnaDoesntEatAnItem_ThenThePortionCalculatedMatchesTheExpectedResult(
            List<int> listOfItemPrices, int indexOfItemAnnaDidntEat, int expectedResult)
        {
            var actualResult = BonAppetit.GetSplit(listOfItemPrices, indexOfItemAnnaDidntEat);
            
            Assert.Equal(expectedResult, actualResult);
        }
        
        public static IEnumerable<object[]> ItemizedBillData =>
            new List<object[]>
            {
                new object[] { new List<int> { 6, 10 }, 1, 3 },
                new object[] { new List<int> { 6, 10 }, 0, 5 },
                new object[] { new List<int> { 6, 10, 12 }, 2, 8 },
                new object[] { new List<int> { 6 }, 0, 0 }
            };
        
        [Fact]
        public void GivenAmountAnnaPaid_WhenAnnaOverpays_ThenTheRefundAmountIsReturned()
        {
            var listOfItemPrices = new List<int> {6, 10, 12};
            var indexOfItemAnnaDidntEat = 2;
            var amountAnnaPaid = 10;
            var expectedResult = "2";
            
            var actualResult = BonAppetit.VerifyCalculation(listOfItemPrices, indexOfItemAnnaDidntEat, amountAnnaPaid);
            
            Assert.Equal(expectedResult, actualResult);
        }
        
        [Fact]
        public void GivenAmountAnnaPaid_WhenAnnaDoesNotGetOvercharged_ThenTheResultIsBonApetite()
        {
            var listOfItemPrices = new List<int> {6, 10, 12};
            var indexOfItemAnnaDidntEat = 2;
            var amountAnnaPaid = 8;
            var expectedResult = BonAppetit.NO_REFUND_DUE;
            
            var actualResult = BonAppetit.VerifyCalculation(listOfItemPrices, indexOfItemAnnaDidntEat, amountAnnaPaid);
            
            Assert.Equal(expectedResult, actualResult);
        }
        
    }
}