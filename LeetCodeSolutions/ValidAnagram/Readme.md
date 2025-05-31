# Problem Name: Valid Anagram

**Difficulty:** Easy

## Problem Description
Given two strings `s` and `t`, return `true` if `t` is an anagram of `s`, and `false` otherwise.  
An anagram is a word or phrase formed by rearranging the letters of another, using all the original letters exactly once.

## Approach / Solution
We use an integer array of size 26 (for each letter from 'a' to 'z') to count character frequencies.

Steps:
- If the lengths of `s` and `t` are different, return `false` immediately (they can't be anagrams).
- Loop through both strings simultaneously:
  - For each character in `s`, increment its corresponding index in the count array.
  - For each character in `t`, decrement its corresponding index.
- Finally, check the count array:
  - If all elements are zero, the strings are anagrams.
  - If any element is non-zero, return `false`.

## Time Complexity
**O(n)** — where `n` is the length of the strings.

## Space Complexity
**O(1)** — constant space (26 letters in the alphabet).

## Code (C#)
```csharp
public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        int[] count = new int[26];
        for (int i = 0; i < s.Length; i++) {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }

        foreach (int c in count) {
            if (c != 0) return false;
        }

        return true;
    }
}
