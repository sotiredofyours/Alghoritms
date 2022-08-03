using NUnit.Framework;

namespace ConsoleApp1._54._Spiral_Matrix;

public class SpiralMatrix
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        int n = matrix.GetLength(0);
        int m = matrix[0].Length;
        int l = 0;
        int x = m*n;
        var result = new List<int>();
        while (result.Count != x)
        {
            for (int i = l; i < m-l; i++)
            {
                result.Add(matrix[l][i]);
            }            
            if (result.Count == x) break;
            for (int i = l+1; i < n - l; i++)
            {
                result.Add(matrix[i][m-l-1]);
            }
            if (result.Count == x) break;
            for (int i = m -l - 2; i > l; i--)
            {
                result.Add(matrix[n-l-1][i]);
            }
            if (result.Count == x) break;
            for (int i = n - 1 - l; i > l; i--)
            {
                result.Add(matrix[i][l]);
            }
            l++;
        }

        return result;
    }

    [Test]
    public void test()
    {
        int[][] x = new int[3][];
        x[0] = new[] {1, 2, 3};
        x[1] = new[] {4, 5, 6};
        x[2] = new[] {7, 8, 9};
        SpiralOrder(x);
      
    }
}