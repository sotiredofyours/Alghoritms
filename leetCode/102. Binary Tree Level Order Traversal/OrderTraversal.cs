using NUnit.Framework.Internal;

namespace ConsoleApp1.leetCode._102._Binary_Tree_Level_Order_Traversal;

public class OrderTraversal
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

    private static List<IList<int>> result = new List<IList<int>>();
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        Helper(root);
        return  result;
    }

    public void Helper(TreeNode root, int level = 0)
    {
        if (root is null) return;
        if (result.Count < level + 1)
        {
            result.Add(new List<int>(root.val));
        }
        else
        {
            result[level].Add(root.val);
        }
        Helper(root.left, level+1);
        Helper(root.right, level+1);
    }
}