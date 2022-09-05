namespace ConsoleApp1.leetCode._429._N_ary_Tree_Level_Order_Traversal;

public class NLevelOrder
{
    public class Node {
        public int val;
        public IList<Node> children;

        public Node() {}

        public Node(int _val) {
            val = _val;
        }

        public Node(int _val, IList<Node> _children) {
            val = _val;
            children = _children;
        }
    }

    private IList<IList<int>> storage = new List<IList<int>>();
    public IList<IList<int>> LevelOrder(Node root) {
        AddNode(root);
        return storage;
    }

    void AddNode(Node root, int level = 0)
    {
        if (root is null) return;
        if (level >= storage.Count)
        {
            storage.Add(new List<int>{root.val});
        }
        else
        {
            storage[level].Add(root.val);
        }

        foreach (var node in root.children)
        {
            AddNode(node, level+1);
        }
    }

}