# Problem Name: Group Anagrams

**Difficulty:** Medium

## Problem Description
Given an array of strings `strs`, group the anagrams together.  
You can return the answer in any order.

An anagram is a word formed by rearranging the letters of another, using all the original letters exactly once.

### Example:
Input: strs = ["eat", "tea", "tan", "ate", "nat", "bat"]
Output: [["eat","tea","ate"],["tan","nat"],["bat"]]


## Approach / Solution
The idea is to use a dictionary to group strings that are anagrams of each other.

Steps:
- Iterate over each string in the input array.
- Convert each string to a character array and sort the characters.
- Use the sorted string as a **key** in a dictionary.
  - All strings with the same sorted key are anagrams of each other.
- Add each original string to the list associated with its sorted key.
- Finally, return all the values from the dictionary as a list of lists.

## Time Complexity
**O(n * k log k)**  
Where `n` is the number of strings and `k` is the maximum length of a string.  
Sorting each string takes `O(k log k)` time.

## Space Complexity
**O(n * k)**  
We use a dictionary to store all strings grouped by their sorted form.

## Code (C#)
```csharp
public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> d1 = new Dictionary<string, List<string>>();
        foreach (string s in strs) {
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string cToString = new string(chars);
            if (!d1.ContainsKey(cToString))
                d1[cToString] = new List<string>();
            d1[cToString].Add(s);
        }
        return new List<List<string>>(d1.Values);
    }
}
