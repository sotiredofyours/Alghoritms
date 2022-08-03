
using NUnit.Framework;

namespace ConsoleApp1._424._Longest_Repeating_Character_Replac;

public class LongestRepeatingSolution
{
    
     public int CharacterReplacement(string s, int k) {
         int len = s.Length;
         int[] count = new int[26];
         int start = 0, maxCount = 0, maxLength = 0;
         for (int end = 0; end < len; end++) {
             maxCount = Math.Max(maxCount, ++count[s[end] - 'A']);
             while (end - start + 1 - maxCount > k) {
                 count[s[start] - 'A']--;
                 start++;
             }
             maxLength = Math.Max(maxLength, end - start + 1);
         }
         return maxLength;
     }

     [Test]
     public void TestSolution()
     {
         var x = CharacterReplacement("ABAA", 0);
         var y = CharacterReplacement("AABABBA", 1);
         var z = CharacterReplacement("ABAB", 2);
         var t = CharacterReplacement("ABBB",2);
         Assert.AreEqual(x, 2);
         Assert.AreEqual(y,4);
         Assert.AreEqual(z, 4);
         Assert.AreEqual(t, 4);
     }
     
    
}