using System;
using Xunit;

namespace TestProject {
    public class CafeOrderChecker {
        [Fact]
        public void ReturnsTrue_WhenFirstComeFirstServe() {
            var takeOutOrders = new int[] {17, 8, 24};
            var dineInOrders = new int[] {12, 19, 2};
            int[] servedOrders = {17, 8, 12, 19, 24, 2};

            var result = checker(takeOutOrders, dineInOrders, servedOrders);

            Assert.True(result);
        }

        [Fact]
        public void ReturnsTrue_WhenFirstComeFirstServeWithRepeatOrders() {
            var takeOutOrders = new int[] {17, 8, 24, 10, 17};
            var dineInOrders = new int[] {12, 19, 2};
            int[] servedOrders = {17, 8, 12, 19, 24, 10, 2, 17};

            var result = checker(takeOutOrders, dineInOrders, servedOrders);

            Assert.True(result);
        }

        [Fact]
        public void ReturnsFalse_WhenNotFirstComeFirstServe() {
            var takeOutOrders = new int[] {1, 3, 5};
            var dineInOrders = new int[] {2, 4, 6};
            int[] servedOrders = {1, 2, 4, 6, 5, 3};

            var result = checker(takeOutOrders, dineInOrders, servedOrders);

            Assert.False(result);
        }

        [Fact]
        public void ReturnsFalse_WhenThereIsAnExtraOrderUnserved() {
            var takeOutOrders = new int[] {17, 8, 24, 10};
            var dineInOrders = new int[] {12, 19, 2};
            int[] servedOrders = {17, 8, 12, 19, 24, 2};

            var result = checker(takeOutOrders, dineInOrders, servedOrders);

            Assert.False(result);
        }
        private bool checker(int[] takeOutOrders, int[] dineInOrders, int[] servedOrders)
        {
            var indexTakeOut = 0;
            var indexDineIn = 0;

            for(int index = 0; index < servedOrders.Length; index++) {
                var currentOrder = servedOrders[index];

                if(indexTakeOut < takeOutOrders.Length && takeOutOrders[indexTakeOut] == currentOrder) {
                    indexTakeOut++;
                }
                else if(indexDineIn < dineInOrders.Length && dineInOrders[indexDineIn] == currentOrder) {
                    indexDineIn++;
                }
                else {
                    return false;
                }
            }    
            if (indexTakeOut != takeOutOrders.Length) {
                return false;
            }
            if (indexDineIn != dineInOrders.Length) {
                return false;
            }
            return true;
        }
    }
}