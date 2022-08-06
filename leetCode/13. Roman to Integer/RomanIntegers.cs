namespace ConsoleApp1.leetCode._13._Roman_to_Integer;

public class RomanIntegers
{
    public int RomanToInt(string s)
    {
        var sum = 0;
        var ch = '0';
        for (int i = 0; i<s.Length; i++)
        {
            if (i+1>=s.Length)  ch = '0';
            else ch = s[i+1];
            switch (s[i])
            {
                case 'X':
                    if (ch == 'L' || ch == 'C') sum -= 10;
                    else sum += 10;
                    break;
                case 'I':
                    if (ch == 'V' || ch == 'X') sum -= 1;
                    else sum += 1;
                    break;
                case 'C':
                    if (ch == 'D' ||ch == 'M') sum -= 100;
                    else sum += 100;
                    break;
                case 'V':
                    sum += 5;
                    break;
                case 'D':
                    sum += 500;
                    break;
                case 'M':
                    sum += 1000;
                    break;
                case 'L':
                    sum += 50;
                    break;
            }
            
        }

        return sum;
    }
}