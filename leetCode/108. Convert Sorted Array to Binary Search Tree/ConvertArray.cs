using NUnit.Framework;

namespace ConsoleApp1.leetCode._108._Convert_Sorted_Array_to_Binary_Search_Tree;

public class ConvertArray
{
 public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
 }

    public TreeNode SortedArrayToBST(int[] nums)
    {
       var mid = nums.Length / 2;
       var root = new TreeNode(nums[mid]);
       root.left = Helper(0, mid - 1,nums);
       root.right = Helper(mid + 1, nums.Length - 1, nums);
       return root;
    }

    private TreeNode Helper(int l, int r, int[] nums)
    {
        if (r < l) return null; 
        var mid =l+( r - l )/ 2;
        return new TreeNode(nums[mid], Helper(l, mid - 1, nums), Helper(mid + 1, r, nums));
    }

}