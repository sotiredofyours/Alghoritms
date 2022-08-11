namespace ConsoleApp1.leetCode._268._Missing_Number;

public class MisNumber
{
    public int MissingNumber(int[] nums) {
        var hash = new HashSet<int>();
        for (int i=0; i<=nums.Length; i++){
            hash.Add(i);
        }
        foreach (var x in nums){
            if (hash.Contains(x)) hash.Remove(x);
        }
        foreach (var res in hash){
            return res;
        }
        return 0;
    }
}