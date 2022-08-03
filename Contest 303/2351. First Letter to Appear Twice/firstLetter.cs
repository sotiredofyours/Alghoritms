namespace ConsoleApp1.Contest_303._2351._First_Letter_to_Appear_Twice;

public class firstLetter
{
    public char RepeatedCharacter(string s)
    {
        var x = new HashSet<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (x.Contains(s[i])) return s[i];
            else
            {
                x.Add(s[i]);
            }
        }

        return '0';
    }
    
}