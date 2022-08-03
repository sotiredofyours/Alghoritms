namespace ConsoleApp1._1._Two_Sum;

public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target) {
        
        for (int i = 0; i < nums.Length; i++)
        {
            var curSum = nums[i];
            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j)
                {
                    if (curSum + nums[j] == target) return new[] {i, j};
                }
            }
        }

        return new[] {0, 1};
    }

    public int[] AnotherTwoSum(int[] nums, int target)
    {
        if( nums.Length < 2)
            return new int[2];
        
        Dictionary<int,int> dic = new Dictionary<int,int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(dic.ContainsKey(target - nums[i]))
                return new int[]{i, dic[target - nums[i]]};
            else if(!dic.ContainsKey(nums[i]))
                dic.Add(nums[i], i);
        }
        
        return new int[2];
    }
}