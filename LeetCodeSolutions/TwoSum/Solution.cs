using System;
using System.Collections.Generic;  

public class TwoSumSolution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> mapNums = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (mapNums.ContainsKey(complement)) return new int[] {mapNums[complement], i};
            if (!mapNums.ContainsKey(nums[i])) mapNums.Add(nums[i], i);
        }
        return Array.Empty<int>();
    }
}
