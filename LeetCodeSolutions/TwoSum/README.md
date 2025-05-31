# Problem Name: Two Sum

**Difficulty:** Easy

## Problem Description
Given an array of integers `nums` and an integer `target`, return the indices `i` and `j` such that `nums[i] + nums[j] == target` and `i != j`.  
You may assume that each input has exactly one solution, and you may not use the same element twice.  
Return the answer with the smaller index first.

## Approach / Solution
We use a dictionary to store numbers and their indices as we iterate through the array.

Steps:
- For each number in the array:
  - Compute the complement: `target - nums[i]`.
  - If the complement is already in the dictionary, return the pair of indices: `[index_of_complement, current_index]`.
  - Otherwise, add the current number and its index to the dictionary.
- If no such pair exists, return an empty array (though by problem constraints, a solution always exists).

## Time Complexity
**O(n)** — We traverse the array once.

## Space Complexity
**O(n)** — For storing up to `n` elements in the dictionary.

## Code (C#)
```csharp
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> mapNums = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (mapNums.ContainsKey(complement)) 
                return new int[] { mapNums[complement], i };
            if (!mapNums.ContainsKey(nums[i])) 
                mapNums.Add(nums[i], i);
        }
        return Array.Empty<int>();
    }
}
