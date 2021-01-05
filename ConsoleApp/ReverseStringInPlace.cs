namespace ConsoleApp {
    public static class ReverseStringInPlace {
        public static char[] reverse(char[] data) {
            var leftIndex = 0;
            var rightIndex = data.Length -1;
            
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