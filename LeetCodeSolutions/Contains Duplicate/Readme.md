# This is problem name ContainsDuplicate 

**Dificult:** Easy

## Problem Description
Given an integer array nums, return true if any value appears more than once in the array, otherwise return false.

## Approach / Solution
The idea is to use HashSet to track seen numbers.
- Iterate through the array.
- If the number is already in the set, return true (duplicate found).
- Otherwise, add a number to the set.
If no duplicates are found after process all numbers, return false.

## Time Complexity
O(n), Where n is the number of element in the array.

## Space Complexity
O(n), due to the HashSet Used for tracking.

## Code (C#)
```csharp
public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> seen = new HashSet<int>();
        foreach (int num in nums) {
            if (seen.Contains(num)) return true;
            seen.Add(num);
        }
        return false;
    }
}
