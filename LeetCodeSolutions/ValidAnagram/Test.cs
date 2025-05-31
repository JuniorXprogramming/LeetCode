using Xunit;

public class ValidAnagramTests
{
    [Fact]
    public void TestIsAnagram()
    {
        var solution = new ValidAnagramSolution();

        Assert.True(solution.IsAnagram("anagram", "nagaram"));
        Assert.False(solution.IsAnagram("rat", "car"));
        Assert.True(solution.IsAnagram("listen", "silent"));
        Assert.False(solution.IsAnagram("hello", "world"));
        Assert.True(solution.IsAnagram("", ""));
        Assert.False(solution.IsAnagram("a", "b"));
    }
}