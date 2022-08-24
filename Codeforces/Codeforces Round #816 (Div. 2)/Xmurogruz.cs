namespace ConsoleApp1.Codeforces.Codeforces_Round__816__Div._2_;
using System;

public class Xmurogruz
{
    public static void Main()
    {
        var t = int.Parse(Console.ReadLine());
        var finalResult = new List<string>();
        for (int i = 0; i < t; i++)
        {
            var input = Console.ReadLine().Split(" ");
            var n = int.Parse(input[0]);
            var m = int.Parse(input[1]);
            var result = 0;
            if (m == 1 && n == 1)
            {
                Console.WriteLine(0);
            }
            if (m < n) result += 2 * m - 1 + n-1;
            else
            {
                result += 2 * n - 1 + m - 1;
            }
            finalResult.Add(result.ToString());
        }

        foreach (var x in finalResult)
        {
            Console.WriteLine(x);
        }
    }
}