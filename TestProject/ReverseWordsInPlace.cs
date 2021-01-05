using System;
using System.Linq;
using ConsoleApp;
using Xunit;

namespace TestProject {
    public class ReverseWordsInPlaceTests {
        [Fact]
        public void reversesWordsOnly() {
            var expected = new char[]{ 't', 'h', 'e', ' ', 'e', 'a', 'g', 'l', 'e', ' ',
                                    'h', 'a', 's', ' ', 'l', 'a', 'n', 'd', 'e', 'd' };
            var input = new char[]{'l', 'a', 'n', 'd', 'e', 'd', ' ', 'h', 'a', 's', ' ',
                                    'e', 'a', 'g', 'l', 'e', ' ', 't', 'h', 'e' };

            var actualResult = ReverseWordsInPlace.reverse(input);

            actualResult.ToList().ForEach(x => Console.WriteLine(x));
            
            Assert.Equal(expected, actualResult);
        }
    }
}