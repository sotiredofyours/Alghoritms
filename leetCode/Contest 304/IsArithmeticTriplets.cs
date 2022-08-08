namespace ConsoleApp1.leetCode.Contest_308;

public class IsArithmeticTriplets
{
    public int ArithmeticTriplets(int[] nums, int diff)
    {
        int counter = 0;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            for (int j = i; j >= 0; j--)
            {
                if (i != j)
                {
                    if (nums[i] - nums[j] == diff)
                    {
                        for (int k = j; k >=0; k--)
                        {
                            if (nums[j] - nums[k] == diff) counter++;
                        }
                    }
                }
            }
        }

        return counter;
    }
}