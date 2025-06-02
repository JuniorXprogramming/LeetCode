# Trapping Rain Water

**Dificult:** Hard

## Approach / Solution

The goal is to calculate how much water is trapped between bars after it rains.

### Core Idea:
We use two pointers (`l` and `r`) to traverse the height array from both ends inward.  
At each step, we track:
- `leftMax`: the maximum height to the **left** of pointer `l`
- `rightMax`: the maximum height to the **right** of pointer `r`

Water can only be trapped if both sides are higher than the current height.

### Why it works:
- Always move the side with **lower height** inward.
- This ensures that the shorter side determines the amount of water that can be trapped.
- At each step, we calculate:
  `water += max(0, min(leftMax, rightMax) - height[current])`

But since we always move the smaller side, we can simplify:
- If `height[l] < height[r]`, we trust `leftMax` is the limiting factor.
- If `height[r] < height[l]`, we trust `rightMax`.

### Example Walkthrough:
Given `height = [0,1,0,2,1,0,1,3,2,1,2,1]`,  
as the pointers move inward, we keep track of the max on each side and accumulate trapped water.

### Time & Space Complexity:
- **Time Complexity:** O(n)  
- **Space Complexity:** O(1)

This is an optimal solution that avoids using extra arrays.
