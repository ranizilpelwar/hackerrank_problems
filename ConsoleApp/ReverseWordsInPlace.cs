using System;

namespace ConsoleApp {
    public static class ReverseWordsInPlace {
        public static char[] reverse(char[] data) {
            var reversedChars = reverse(data, 0, data.Length -1);

            var wordStartIndex = 0;
            
            for(int i = 0; i <= data.Length; i++) {
                if (i == data.Length || data[i] == ' ') {
                    reverse(data, wordStartIndex, i-1);
                    wordStartIndex = i+1;
                }
            }
            return reversedChars;
        }

        public static char[] reverse(char[] data, int leftIndex, int rightIndex) {
            while (leftIndex < rightIndex) {
                var temp = data[leftIndex];
                data[leftIndex] = data[rightIndex];
                data[rightIndex] = temp;

                leftIndex++;
                rightIndex--;
            }

            return data;
        }
    }
}