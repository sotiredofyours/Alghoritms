using System.Text;

namespace ConsoleApp1._14._Longest_Common_Prefix;

public class LongestPrefix
{
    public string LongestCommonPrefix(string[] strs)
    {
        var prefix = new StringBuilder();
        for (int i = 0; i < strs[0].Length; i++)
        {
            var currentChar = strs[0][i];
            for (int j = 0; j < strs.Length; j++)
            {
                if (strs[j][i] != currentChar || strs[j].Length == i ) return prefix.ToString();
            }
            prefix.Append(currentChar);
        }

        return prefix.ToString();
    }
}