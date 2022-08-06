namespace ConsoleApp1.leetCode._383._Ransom_Note;

public class RansomNote
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        char[] symbols = new char[100];
        foreach (var x in magazine)
        {
            symbols[x - '0']++;
        }
        foreach (var y in ransomNote)
        {
            if (symbols[y - '0'] == 0) return false;
            symbols[y - '0']--;
        }
        return true;
    }
}