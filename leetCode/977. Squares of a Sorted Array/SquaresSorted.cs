namespace ConsoleApp1.leetCode._977._Squares_of_a_Sorted_Array;

public class SquaresSorted
{
    public int[] SortedSquares(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];
        int i = 0, j = n - 1;
        for (int p = n - 1; p >= 0; p--) {
            if (Math.Abs(nums[i]) > Math.Abs(nums[j])) {
                result[p] = nums[i] * nums[i];
                i++;
            } else {
                result[p] = nums[j] * nums[j];
                j--;
            }
        }
        return result;
    }
}