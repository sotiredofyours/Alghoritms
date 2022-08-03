
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;

public class BallFall
{
    private static int m;
    private static int n;
    public int[] FindBall(int[][] grid)
    {
        n = grid.GetLength(0);
        m = grid[0].Length;
        var result = new int[n];
        for (int i = 0; i < n; i++)
        {
            result[i] = Helper(i, grid);
        }

        return result;
    }

    public static int Helper(int startColumn, int[][] grid)
    {
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            if (grid[i][startColumn] == 1)
            {
                if (startColumn == m - 1 || grid[i][startColumn - 1] == -1) return -1;
                startColumn++;
            }

            if (grid[i][startColumn] == -1)
            {
                if (startColumn == 0 || grid[i][startColumn + 1] == 1) return -1;
                startColumn--;
            }
        }
        return startColumn;
    }
    
}