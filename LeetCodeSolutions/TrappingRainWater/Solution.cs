using System;
using System.Collections.Generic;

public class TrappingRainWaterSolution {
    public int Trap(int[] height)
    {
        int l = 0, r = height.Length - 1;
        int leftMax = height[l], rightMax = height[r];
        int water = 0;

        while (l < r)
        {
            if (height[l] < height[r])
            {
                l += 1;
                leftMax = Math.Max(leftMax, height[l]);
                water += Math.Max(0, leftMax - height[l]);
            }
            else
            {
                r -= 1;
                rightMax = Math.Max(rightMax, height[r]);
                water += Math.Max(0, rightMax - height[r]);
            }
        }

        return water;
    }
}
