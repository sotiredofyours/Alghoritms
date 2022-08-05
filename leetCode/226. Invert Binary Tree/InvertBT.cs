namespace ConsoleApp1.leetCode._226._Invert_Binary_Tree;


 
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
 
public class InvertBT
{
    public TreeNode InvertTree(TreeNode root)
    {
        
        Helper(root);
        return root;
    }
    
    public static void Helper(TreeNode root)
    {
        if (root is null) return;
        
        (root.left, root.right) = (root.right, root.left);
        
        Helper(root.left);
        Helper(root.right);
    }
}