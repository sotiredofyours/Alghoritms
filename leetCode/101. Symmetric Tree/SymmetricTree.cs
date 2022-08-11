namespace ConsoleApp1.leetCode._101._Symmetric_Tree;

public class SymmetricTree
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
    
    public bool IsSymmetric(TreeNode root) {
        return Helper(root.left, root.right);
    }

    public static bool Helper(TreeNode left, TreeNode right)
    {
        if (left is null && right is null) return true;
        if (left is null || right is null) return false;
        if (left.val != right.val) return false;
        return Helper(left.left, right.left) && Helper(left.right, right.right);
    }
}