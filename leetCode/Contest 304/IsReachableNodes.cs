namespace ConsoleApp1.leetCode.Contest_308;

public class IsReachableNodes
{
    public int ReachableNodes(int n, int[][] edges, int[] restricted) {
        Dictionary<int, List<int>> map = new();
        bool[] visited = new bool[n];
        int count = 0;
        
        foreach(int vertex in restricted)
            visited[vertex] = true;
        
        foreach(int[] edge in edges){
            map.TryAdd(edge[0], new List<int>());
            map.TryAdd(edge[1], new List<int>());
            
            map[edge[0]].Add(edge[1]);
            map[edge[1]].Add(edge[0]);
        }
        
        Queue<int> queue = new();
        queue.Enqueue(0);
        visited[0] = true;
        
        while(queue.Count > 0){
            var node = queue.Dequeue();
            count++;
            
            foreach(int child in map[node]){
                if(!visited[child]){
                    queue.Enqueue(child);
                    visited[child] = true;
                }
            }
        }
        
        return count;
    }
    
}