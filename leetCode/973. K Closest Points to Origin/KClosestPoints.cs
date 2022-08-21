namespace ConsoleApp1.leetCode._973._K_Closest_Points_to_Origin;

public class KClosestPoints
{
    public int[][] KClosest(int[][] points, int k)
    {
        var list = new List<int[]>();
        foreach(var x in points) list.Add(x);
        var result = list.OrderBy(x => Math.Sqrt(x[0] * x[0] + x[1] * x[1])).Reverse().ToArray();
        return result.Take(k).ToArray();
    }
}