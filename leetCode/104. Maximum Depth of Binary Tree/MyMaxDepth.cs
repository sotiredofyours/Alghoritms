namespace ConsoleApp1.leetCode._104._Maximum_Depth_of_Binary_Tree;

public class MyMaxDepth
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
    public int MaxDepth(TreeNode root)
    {
        return Helper(root);
    }

    public int Helper(TreeNode root)
    {
        if (root == null) return 0;
        var right = 1+Helper(root.right);
        var left = 1+ Helper(root.left);
        return Math.Max(left, right);
    }
}