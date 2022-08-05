using NUnit.Framework;

namespace ConsoleApp1.leetCode._53._Maximum_Subarray;

public class MaximumSubarray
{
    public int MaxSubArray(int[] nums)
    {
        int maxSum = nums[0];
        int currSum = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            currSum += nums[i];
            if (currSum < 0)
            {
                currSum = 0;
            }

            if (currSum > maxSum)
            {
                maxSum = currSum;
            }
        }

        return maxSum;

    }

    public int SecondMaxSubArray(int[] nums)
    {
        var maxSum = nums[0];
        var curSum = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            curSum = Math.Max(nums[i], curSum + nums[i]);
            if (curSum > maxSum) maxSum = curSum;
        }

        return maxSum;
    }
    
}