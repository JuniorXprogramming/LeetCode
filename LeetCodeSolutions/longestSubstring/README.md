# Problem Name: Longest Substring Without Repeating Characters

**Difficulty:** Medium

## Problem Description
Given a string `s`, find the length of the longest substring without repeating characters.

---

## Approach / Solution

This problem can be solved using the **sliding window technique** along with a boolean array to track characters seen in the current window.

### Key Idea:
- Use two pointers `left` and `right` to represent the current window of substring without duplicates.
- Move `right` pointer to expand the window by including new characters.
- If a duplicate character is encountered, move the `left` pointer forward until the duplicate is removed.
- Track the maximum length of the window during this process.

### Steps:
1. Initialize a boolean array `seen` of size 128 (to cover all ASCII characters).
2. Iterate `right` over the string characters:
   - If the current character `s[right]` has already been seen, move `left` pointer forward, marking characters as unseen until the duplicate is removed.
   - Mark the current character as seen.
   - Update the maximum length `longest` if the current window size (`right - left + 1`) is greater.

---

## Time Complexity
- **O(n)**, where `n` is the length of the string, since each character is visited at most twice.

## Space Complexity
- **O(1)**, because the size of the `seen` array is fixed (128).

---

## Code (C#)

```csharp
using System;

public class LongestSubStringSolution 
{
    public int FindLongest(string s)
    {
        int longest = 0, left = 0;
        bool[] seen = new bool[128];
        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];
            while (seen[c])
            {
                seen[s[left]] = false;
                left++;
            }

            seen[c] = true;
            longest = Math.Max(longest, right - left + 1);
        } 

        return longest;
    }
}
