namespace ConsoleApp1.leetCode._9._Palindrome_Number;

public class PalNumber
{
    public bool IsPalindrome(int x) {
        if(x < 0 || (x % 10 == 0 && x != 0)) {
            return false;
        }
        var sum = 0;
        while (x> sum){
            sum = sum * 10 + x % 10;
            x /= 10;
         
        }
        return x == sum || x == sum/10;
    }
}