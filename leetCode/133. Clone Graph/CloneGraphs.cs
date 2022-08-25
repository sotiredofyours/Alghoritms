namespace ConsoleApp1.leetCode._133._Clone_Graph;

public class CloneGraphs
{
    public class Node {
        public int val;
        public IList<Node> neighbors;

        public Node() {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val) {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors) {
            val = _val;
            neighbors = _neighbors;
        }
    } 
    Dictionary<int, Node> visited = new Dictionary<int, Node>();
    public Node CloneGraph(Node node)
    {
        return CloneNode(node);
    }

    private Node CloneNode(Node node)
    {
        if (node is null) return null;
        if (visited.ContainsKey(node.val)) return visited[node.val];
        
        var resNode = new Node(node.val);
        visited.Add( resNode.val, resNode);
        foreach (var neighbor  in node.neighbors)
        {
            resNode.neighbors.Add(CloneNode(neighbor));
        }

        return resNode;
    }
}