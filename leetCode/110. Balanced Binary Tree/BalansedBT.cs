using NUnit.Framework;

namespace ConsoleApp1.leetCode._110._Balanced_Binary_Tree;

public class BalansedBT
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
    public bool IsBalanced(TreeNode root)
    {
        if (root is null) return true;
        
        var left = Helper(root.left);
        var right = Helper(root.right);

        return Math.Abs(left - right) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
    }

    private static int Helper(TreeNode root)
    {
        if (root is null) return 0;
        return 1+ Math.Max(Helper(root.left), Helper(root.left));
    }

   

}