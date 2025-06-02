using Xunit;

public class longestSubstringTests
{
    [Fact]
    public void TestLongestSubstring()
    {
        var solution = new LongestSubStringSolution();
        Assert.Equal(3, solution.FindLongest("abcabcbb"));
        Assert.Equal(1, solution.FindLongest("bbbbb"));
        Assert.Equal(3, solution.FindLongest("pwwkew"));
        Assert.Equal(0, solution.FindLongest(""));
        Assert.Equal(2, solution.FindLongest("au"));
        Assert.Equal(3, solution.FindLongest("dvdf"));
    }
}