using Xunit;

public class TwoSumTests
{
    [Fact]
    public void TestTwoSum()
    {
        var solution = new TwoSumSolution();

        Assert.Equal(new int[] { 0, 1 }, solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9));
        Assert.Equal(new int[] { 1, 2 }, solution.TwoSum(new int[] { 3, 2, 4 }, 6));
        Assert.Equal(new int[] { 0, 1 }, solution.TwoSum(new int[] { 3, 3 }, 6));
        Assert.Equal(new int[] { }, solution.TwoSum(new int[] { 1, 2, 3 }, 7));
        Assert.Equal(new int[] { }, solution.TwoSum(new int[] { }, 0));
    }
}