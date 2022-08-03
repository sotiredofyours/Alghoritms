using NUnit.Framework;

namespace ConsoleApp1._438._Find_All_Anagrams_in_a_String;

public class AnagramsSolution
{
    public List<int> findAnagrams(String s, String p) {
        int[] map = new int[26];
        List<int> result = new List<int>();
        
        for(int i=0;i<p.Length;i++){
            map[p[i] - 'a']++;
        }
    
        int windowStart = 0;
        int windowEnd = 0;
        while(windowEnd<s.Length){
            // valid anagram
            if(map[s[windowEnd] - 'a'] > 0){
                map[s[windowEnd++] - 'a']--;
                // window size equal to size of P
                if(windowEnd-windowStart ==  p.Length){                    
                    result.Add(windowStart);
                }
            }
            // window is of size 0
            else if(windowStart == windowEnd){
                windowStart ++;
                windowEnd ++;
            }
            // decrease window size
            else{
                map[s[windowStart++] - 'a']++;
            }      
        }
        return result;
    }
}