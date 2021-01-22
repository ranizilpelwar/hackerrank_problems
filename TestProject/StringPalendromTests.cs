using System.Collections.Generic;
using Xunit;

public class StringPalendromeTests {
    [Fact]
    public void ReturnsTrueWhenPalendromeAndOddLength() {
        var input = "civic";
        
        var result = ContainsPalendrome(input);

        Assert.True(result);
    }

    [Fact]
    public void ReturnsTrueWhenPalendromeAndEvenLength() {
        var input = "aahh";
        
        var result = ContainsPalendrome(input);

        Assert.True(result);
    }

    [Fact]
    public void ReturnsFalseWhenNotAndEvenLength() {
        var input = "aach";
        
        var result = ContainsPalendrome(input);

        Assert.False(result);
    }

    
    [Fact]
    public void ReturnsFalseWhenNotAndOddLength() {
        var input = "civicba";

        var result = ContainsPalendrome(input);

        Assert.False(result);
    }

    private bool ContainsPalendrome(string input)
    {
        var map = new Dictionary<char, int>();

        foreach(var letter in input) {
            if(map.ContainsKey(letter)) {
                map[letter]++;
            }
            if (!map.ContainsKey(letter)) {
                map[letter] = 1;
            }
        }

        var countOfOdds = 0;
        foreach(var current in map) {
            if (current.Value % 2 == 1) {
                countOfOdds++;
            }
        }
        if (input.Length % 2 == 0 && countOfOdds == 0)
            return true;

        if (input.Length % 2 == 1 && countOfOdds == 1) 
            return true;

        return false;
    }
}