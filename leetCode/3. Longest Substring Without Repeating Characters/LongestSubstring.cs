using NUnit.Framework;

namespace ConsoleApp1.leetCode._3._Longest_Substring_Without_Repeating_Characters;

public class LongestSubstring
{
    public int LengthOfLongestSubstring(string s) {
        var maxLength = 1;
        if (s.Length < 2) return s.Length;
        var l = 0;
        var r = l;
        var hash = new HashSet<char>();
        while (r<s.Length)
        {
            if (hash.Contains(s[r]))
            {
                if (r - l > maxLength) maxLength = r - l;
                while (s[l]!=s[r])
                {
                    hash.Remove(s[l]);
                    l++;
                }

                l++;
            }
            else
            {
                hash.Add(s[r]);
            } 
            r++;
        }
        if (r - l > maxLength) maxLength = r - l;
        return maxLength;
    }
}