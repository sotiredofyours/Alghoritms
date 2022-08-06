using System.Xml.Xsl;

namespace ConsoleApp1.leetCode._543._Diameter_of_Binary_Tree;

public class DiameterBT
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
    public int DiameterOfBinaryTree(TreeNode root) {
        {
            if (root is null) return 0;
            var y = Helper(root.left);
            var x = Helper(root.right);
            return Math.Max(y+x, Math.Max(DiameterOfBinaryTree(root.left), DiameterOfBinaryTree(root.right)));
        }

        static int Helper(TreeNode root, int steps = 0)
        {
            if (root is null) return steps;
            else
            {
                steps++;
            }
            return Math.Max(Helper(root.left, steps), Helper(root.right, steps));
        }
    }
}