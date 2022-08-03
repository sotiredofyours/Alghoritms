using NUnit.Framework;

namespace ConsoleApp1._62._Unique_Paths;

public class UniquePathsSolution
{
    public static int[,] storage;
    public int UniquePaths(int m, int n)
    {
        storage = new int[m, n];
        storage[0, 0] = 1;
        if (m > 1) storage[1, 0] = 1;
        if (n > 1) storage[0, 1] = 1;
        return FindPath(m - 1, n - 1);
    }

    public static int FindPath(int m, int n)
    {
        if (m < 0 || n < 0 || m >= storage.GetLength(0) || n >= storage.GetLength(1)) return 0;
        if (storage[m, n] != 0) return storage[m, n];
        storage[m, n] = FindPath(m - 1, n) + FindPath(m, n - 1);
        return storage[m, n];
    }

    [Test]
    public void test()
    {
        var s = new UniquePathsSolution().UniquePaths(1, 2);
        Assert.AreEqual(s, 2);
    }
}