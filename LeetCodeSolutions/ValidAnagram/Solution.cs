using System;
using System.Collections.Generic;  

public class ValidAnagramSolution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        int[] countChar = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            countChar[s[i] - 'a']++;
            countChar[t[i] - 'a']--;
        }
        foreach (int num in countChar)
        {
            if (num != 0) return false;
        }
        return true;
    }
}
