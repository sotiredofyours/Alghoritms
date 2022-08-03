using System;
using System.Collections.Generic;

public class SixSolution
{
    public string Name
    {
        get
        {
            return Name;
        }
        set
        {
            Name = value.Length == 0 ? value: throw new Exception();
        }
    }

    public static int[] FindTwo(int[] numbers)
    {
        var incorrectEven = new List<int>();
        var incorrectOdd = new List<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if ((i + 1) % 2 == 0)
            {
                if (numbers[i] % 2 != 0)
                {
                    incorrectEven.Add(i + 1);
                }
            }
            else
            {
                if (numbers[i] % 2 == 0)
                {
                    incorrectOdd.Add(i + 1);
                }
            }
        }

        if (incorrectEven.Count == incorrectOdd.Count && incorrectEven.Count == 1)
            return new[] {Math.Min(incorrectEven[0], incorrectOdd[0]), Math.Max(incorrectEven[0], incorrectOdd[0])};
        return new[] {-1, -1};
    }
    
public static void Main()
{
    var n = int.Parse(Console.ReadLine()!);
        var input = Console.ReadLine();
        var inp = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int [n];
        for (int i = 0; i < inp.Length; i++)
        {
            numbers[i] = int.Parse(inp[i]);
        }

        var result = FindTwo(numbers);
        Console.WriteLine($"{result[0]} {result[1]}");
} 
}
