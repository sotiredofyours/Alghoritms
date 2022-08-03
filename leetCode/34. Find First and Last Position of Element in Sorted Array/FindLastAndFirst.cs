using NUnit.Framework;

namespace ConsoleApp1._34._Find_First_and_Last_Position_of_Element_in_Sorted_Array;

public class FindLastAndFirst
{
    public int[] SearchRange(int[] nums, int target)
    {
        int l = 0;
        int r = nums.Length-1;
        if (r < l) return new[] {-1, -1};
        while (l < r)
        {
            int m = l + (r-l+1)/2;
            if (nums[m] > target) r = m-1;
            else
            {
                l = m;
            }
        }

        if (nums[l] != target) return new[] {-1, -1};
       
        while (l-1 >= 0 && nums[l-1] == target )
        {
            l--;
        }
        while (r+1 < nums.Length-1 && nums[r+1] == target )
        {
            r++;
        }

        return new[] {l, r};
    }

    [Test]
    public void test()
    {
        var x = new int[] {0};
        Assert.AreEqual(SearchRange(x, 0), new int[]{0,0});
    }
}