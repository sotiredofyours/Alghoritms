namespace ConsoleApp1._746._Min_Cost_Climbing_Stairs;

public class MinCost
{
    public static int[] storage;
    public int MinCostClimbingStairs(int[] cost)
    {
        var n = cost.Length;
        storage = new int[n];
        return Math.Min(CountCost(cost, n - 1), CountCost(cost, n - 2));

    }
    public static int CountCost(int[] cost, int position)
    {
        if (position < 0) return 0;
        if (position == 1 || position == 0) return cost[position];
        if (storage[position] != 0) return storage[position];
        storage[position] = cost[position] + Math.Min(CountCost(cost, position - 1), CountCost(cost, position - 2));
        return storage[position];
    }
    

}