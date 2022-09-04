
namespace ConsoleApp1.leetCode._987._Vertical_Order_Traversal_of_a_Binary_Tree;

public class VerticalBt
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

 public class Solution
 {
     public class Point
     {
         public Point(int rootVal, int dy)
         {
             Val = rootVal;
             Dy = dy;
         }

         public int Val { get; set; }
         public int Dy { get; set; }
     }
     private SortedDictionary<int, List<Point>> storage = new SortedDictionary<int, List<Point>>();
     public IList<IList<int>> VerticalTraversal(TreeNode root)
     {
         var result = new List<IList<int>>();
        AddNode(root, 100, 0);

        foreach (var level in storage)
        {
            var list = new List<int>();
            foreach (var point in level.Value)
            {
                list.Add(point.Val);
            }
            result.Add(new List<int>(list));
        }
        result.Reverse();
        return result;
     }

     void AddNode(TreeNode root, int dx, int dy)
     {
         if (root is null) return;
         if (storage.Keys.Contains(dx))
         {
             storage[dx].Add(new Point(root.val, dy));
             storage[dx] = storage[dx].OrderBy(x => x.Dy).ThenBy(x => x.Val).ToList();
         }
         else
         {
             storage.Add(dx, new List<Point>{new Point(root.val, dy)});
         }
         AddNode(root.left, dx+1, dy+1);
         AddNode(root.right, dx-1, dy+1);
     }
 }
}