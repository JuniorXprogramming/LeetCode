using Xunit;

public class TrappingRainWaterTests {
    [Fact]
    public void TestTrap() {
        var solution = new TrappingRainWaterSolution();
        
        // Test case 1
        int[] height1 = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
        int expected1 = 6;
        Assert.Equal(expected1, solution.Trap(height1));

        // Test case 2
        int[] height2 = { 4, 2, 0, 3, 2, 5 };
        int expected2 = 9;
        Assert.Equal(expected2, solution.Trap(height2));

        // Test case with no water trapped
        int[] height3 = { 1, 0, 1 };
        int expected3 = 1;
        Assert.Equal(expected3, solution.Trap(height3));
    }
}