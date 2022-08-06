namespace ConsoleApp1.leetCode._217._Contains_Duplicate;

public class ContainsDuplicated
{
    public bool ContainsDuplicate(int[] nums)
    {
        var set = new HashSet<int>();
        foreach (var x in nums)
        {
            if (set.Contains(x)) return true;
            set.Add(x);
        }

        return false;
    }
}