using System.Drawing;
using NUnit.Framework;

namespace ConsoleApp1.leetCode._542._01_Matrix;

public class ZeroOneMatrix
{
    public int[][] UpdateMatrix(int[][] mat)
    {
        int m = mat.GetLength(0);
        int n = mat[0].Length;
        
        var queue = new Queue<int[]>();
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (mat[i][j] == 0) {
                    queue.Enqueue(new int[] {i, j});
                }
                else {
                    mat[i][j] = Int32.MaxValue;
                }
            }
        }
        
        int[][] dirs =  new int[4][];
        dirs[0] = new[] {-1, 0};
        dirs[1] = new[] {1, 0};
        dirs[2] = new[] {0, -1};
        dirs[3] = new[] {0, 1};
        
        while (queue.Count>0) {
            int[] cell = queue.Dequeue();
            foreach (var d in dirs) {
                int r = cell[0] + d[0];
                int c = cell[1] + d[1];
                if (r < 0 || r >= m || c < 0 || c >= n || 
                    mat[r][c] <= mat[cell[0]][cell[1]] + 1) continue;
                queue.Enqueue(new int[] {r, c});
                mat[r][c] = mat[cell[0]][cell[1]] + 1;
            }
        }
        
        return mat;
    }
}