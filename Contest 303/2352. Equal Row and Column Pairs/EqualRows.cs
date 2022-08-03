using System.Text;
using NUnit.Framework;

namespace ConsoleApp1.Contest_303._2352._Equal_Row_and_Column_Pairs;

public class EqualRows
{
    public int EqualPairs(int[][] grid)
    {
        var count = 0;
        var rows = new List<string>();
        var columns = new List<string>();
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            var row = new StringBuilder();
            var column = new StringBuilder();
            for (int j = 0; j < grid.GetLength(0); j++)
            {
                row.Append(grid[i][j] + " ");
                column.Append(grid[j][i]+ " ");
            }
            rows.Add(row.ToString());
            columns.Add(column.ToString());
        }
        
        for (int i = 0; i < rows.Count; i++)
        {
            for (int j = 0; j < columns.Count; j++)
            {
                if (rows[i] == columns[j])
                {
                    count++;
                }
            }
        }

        return count;
    }

    [Test]
    public void sooqa()
    {
        var x = new int[][] {new int[] {11, 1}, new[] {1, 11}};
        Assert.AreEqual(2, EqualPairs(x));
    }
}