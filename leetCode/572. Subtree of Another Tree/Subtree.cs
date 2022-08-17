using NUnit.Framework;

namespace ConsoleApp1.leetCode._572._Subtree_of_Another_Tree;

public class Subtree
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
     
      public bool IsSubtree(TreeNode s, TreeNode t) {
          if (s == null)
              return false;
          else if (s.val == t.val && IsSameTree(s, t))
              return true;
          else
              return IsSubtree(s.left, t) || IsSubtree(s.right, t);
      }
    
      private bool IsSameTree(TreeNode n1, TreeNode n2)
      {
          if (n1 == null && n2 == null)
              return true;
          else if (n1 == null || n2 == null)
              return false;
        
          return n1.val == n2.val && IsSameTree(n1.left, n2.left) && IsSameTree(n1.right, n2.right);
      }

    
  
}