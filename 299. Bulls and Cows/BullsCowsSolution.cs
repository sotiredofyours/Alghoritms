using NUnit.Framework;

namespace ConsoleApp1._299._Bulls_and_Cows;

public class BullsCowsSolution
{
    public string GetHint(string secret, string guess)
    {
        var cows = 0;
        var bulls = 0;
        var dictSecret = new Dictionary< char,int>();
        for (int i = 0; i < secret.Length; i++)
        {
            if (dictSecret.ContainsKey(secret[i]))
            {
                dictSecret[secret[i]]++;
            }
            else
            {
                dictSecret.Add(secret[i],1);
            }
           
        }

        
        for (int i = 0; i < guess.Length; i++)
        {
            if (dictSecret.ContainsKey(guess[i]))
            {
                if (guess[i] == secret[i]) bulls++;
                dictSecret[guess[i]]--;
            }
        }
        
        for (int i = 0; i < guess.Length; i++)
        {
            if (dictSecret.ContainsKey(guess[i]))
            {
                if (dictSecret[guess[i]] > 0) cows++;
                dictSecret[guess[i]]--;
            }
        }

        return $"{bulls}A{cows}B";
    }

    [Test]
    public void TestSolution()
    {
        var v = GetHint("1122", "1222");
        Assert.AreEqual("3A0B", v);
    }
    
}