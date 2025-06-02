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