using ConsoleApp1._114._Flatten_Binary_Tree_to_Linked_List;

namespace ConsoleApp1._242._Valid_Anagram;

public class Anagram
{
    public bool IsAnagram(string s, string t)
    {
        Console.WriteLine('a'-'0');
        if (s.Length != t.Length) return false;
        var letters = new int[1024];
        for (int i = 0; i < s.Length; i++)
        {
            letters[s[i] - '0']++;
            letters[t[i] - '0']--;
        }

        foreach (var x in letters)
        {
            if (x != 0) return false;
        }

        return true;
    }
}