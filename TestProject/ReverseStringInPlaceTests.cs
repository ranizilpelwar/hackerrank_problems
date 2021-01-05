using ConsoleApp;
using Xunit; 

namespace TestProject {
    public class ReverseStringInPlaceTests {
        [Fact]
        public void returnsReverse() {
            var input = new char[] {'b', 'a', 'n', 'a', 'n', 'a'};
            var expected = new char[] {'a', 'n', 'a', 'n', 'a', 'b'};

            var actual = ReverseStringInPlace.reverse(input);

            Assert.Equal(expected, actual);
        }
    }
}