using Xunit;

public class MaxProfitTests
{
    [Fact]
    public void TestMaxProfit()
    {
        var solution = new MaxProfitSolution();

        // Test case 1
        int[] prices1 = { 7, 1, 5, 3, 6, 4 };
        int expected1 = 5; // Buy at 1 and sell at 6
        Assert.Equal(expected1, solution.MaxProfit(prices1));

        // Test case 2
        int[] prices2 = { 7, 6, 4, 3, 1 };
        int expected2 = 0; // No profit can be made
        Assert.Equal(expected2, solution.MaxProfit(prices2));

        // Test case with a single price
        int[] prices3 = { 5 };
        int expected3 = 0; // No profit can be made with a single price
        Assert.Equal(expected3, solution.MaxProfit(prices3));
    }
}