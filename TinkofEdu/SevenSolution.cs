using System.Security.Cryptography;
using NUnit.Framework;

namespace ConsoleApp1.TinkofEdu;

public class SevenSolution

{
    public class Graph
    {
        public int Count { get; set; }
        public Graph ConnectedTo { get; set; }
    }
    public static int[] FindRightPath(int[] numbers)
    {
        Graph[] nodes = new Graph[numbers.Length];
        for (int i = 0; i < nodes.Length; i++)
        {
            nodes[i] = new Graph();
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            
        }

        return new[] {-1, -1};
    }
    
    [Test]
    public void TestSol()
    {
        var x = new int[] {1, 3, 1};
        var y = FindRightPath(x);
    }
    
}