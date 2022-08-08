namespace ConsoleApp1.leetCode._136._Single_Number;

public class MySingleNumber
{
    public int SingleNumber(int[] nums)
    {
        var x = new HashSet<int>();
        foreach (var y in nums)
        {
            if (x.Contains(y))
            {
                x.Remove(y);
            }
            else
            {
                x.Add(y);
            }
        }

        foreach (var z in x)
        {
            return z;
        }

        return 0;
    }
}