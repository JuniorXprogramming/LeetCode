using System;
using System.Collections.Generic;

public class GroupAnagramsSolution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> d1 = new Dictionary<string, List<string>>();
        foreach (string s in strs)
        {
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string cToString = new String(chars);
            if (!d1.ContainsKey(cToString)) d1[cToString] = new List<string>();
            d1[cToString].Add(s);
        }
        return new List<List<string>>(d1.Values);
    }
}
