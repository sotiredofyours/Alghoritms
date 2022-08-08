namespace ConsoleApp1.leetCode._100._Same_Tree;

public class SameTree
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
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        return Helper(p, q);
    }

    public static bool Helper(TreeNode p, TreeNode q)
    {
        if (p is null || q is null)
        {
            if (p != q) return false;
            return true;
        }
        if (p.val != q.val) return false;
        return Helper(p.left, q.left) && Helper(p.right, q.right);
    }
}