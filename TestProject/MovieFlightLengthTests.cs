using System.Collections.Generic;
using Xunit;

public class MovieFlightLengthTests {
    [Fact]
    public void ReturnsTrueWhenThereIsAMatch() {
        var flightLength = 65;
        var movieLengths = new int[]{ 30, 40, 35, 55};

        var result = hasMatch(flightLength, movieLengths);

        Assert.True(result);
    }

    [Fact]
    public void DoesntReturnFalsePositive() {
        var flightLength = 60;
        var movieLengths = new int[]{ 30, 40, 35, 55};

        var result = hasMatch(flightLength, movieLengths);

        Assert.False(result);
    }

    private bool hasMatch(int flightLength, int[] movieLengths)
    {
        var movies = new HashSet<int>();
        foreach(var currentLength in movieLengths) {
            var diff = flightLength - currentLength;
            if (movies.Contains(diff)) {
                return true;
            }
            if (!movies.Contains(diff)) {
                movies.Add(currentLength);
            }
        }
        return false;
    }

        private bool hasMatchOld(int flightLength, int[] movieLengths)
    {
        var differences = new Dictionary<int, int>();
        foreach(var currentLength in movieLengths) {
            var diff = flightLength - currentLength;
            if (differences.ContainsKey(currentLength)) {
                return true;
            }
            if (!differences.ContainsKey(diff)) {
                differences[diff] = currentLength;
            }
        }
        return false;
    }
}