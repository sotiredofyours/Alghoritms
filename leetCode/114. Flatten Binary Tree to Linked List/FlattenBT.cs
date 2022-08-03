using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using NUnit.Framework;

namespace ConsoleApp1._114._Flatten_Binary_Tree_to_Linked_List;



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
 
// 1.  root.val = curnode.val
// 2. if root.right is not null - add to stack.
// 3. if root.left is not null - add to stack
// 4. while stack is not empty

public class FlattenBT
{
    public void Flatten(TreeNode root)
    {
        if (root == null) return;
        
        TreeNode left = root.left;
        TreeNode right = root.right;
        
        root.left = null;
        
        Flatten(left);
        Flatten(right);
        
        root.right = left;
        TreeNode cur = root;
        while (cur.right != null) cur = cur.right;
        cur.right = right;
    }
    

    [Test]
    public void test()
    {
        var tree = new TreeNode(1, new TreeNode(2, new TreeNode(3, null, null), new TreeNode(4, null, null)));
        var res = new TreeNode(1, null, new TreeNode(2, null, new TreeNode(3, null, new TreeNode(4, null, null))));
        Flatten(tree);
        Assert.AreEqual(tree, res);
    }
}