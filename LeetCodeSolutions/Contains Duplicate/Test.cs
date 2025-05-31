using Xunit;

public class ContainsDuplicateTests
{
    [Fact]
    public void TestHasDuplicate()
    {
        var solution = new Solution();
        
        Assert.True(solution.hasDuplicate(new int[] { 1, 2, 3, 1 }));
        Assert.False(solution.hasDuplicate(new int[] { 1, 2, 3, 4 }));
        Assert.True(solution.hasDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));
        Assert.False(solution.hasDuplicate(new int[] { }));
        Assert.True(solution.hasDuplicate(new int[] { -1, -2, -3, -1 }));
    }
}