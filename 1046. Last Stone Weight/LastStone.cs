using NUnit.Framework;

namespace ConsoleApp1._1046._Last_Stone_Weight;

public class LastStone
{
    public int LastStoneWeight(int[] stones)
    {
        if (stones.Length == 1) return stones[0];
        var removed = 0;
        while (removed<stones.Length-1)
        {
            var y = findIndexOfMax(stones, -1);
            var x = findIndexOfMax(stones, y);
            removed++;
            if (stones[x] != stones[y])
            {
                stones[y] -= stones[x];
                stones[x] = -1;
            }
            else
            {
                if (removed == stones.Length - 1) return 0;
                stones[y] = -1;
                stones[x] = -1;
                removed++;
            }
        }

        foreach (var x in stones)
        {
            if (x != -1) return x;
        }

        return removed;
    }

    int findIndexOfMax(int[] stones, int index)
    {
        if (index == -1)
        {
            var max = Int32.MinValue;
            var j = 0;
            for (int i = 0; i < stones.Length; i++)
            {
                if (stones[i] >= max)
                {
                    max = stones[i];
                    j = i;
                }
            }

            return j;
        }
        else
        {
            var max = Int32.MinValue;
            var j = 0;
            for (int i = 0; i < stones.Length; i++)
            {
                if (stones[i] >= max && i!=index)
                {
                    max = stones[i];
                    j = i;
                }
            }

            return j;
        }
    }

    [Test]
    public void test()
    {
        var x = new int[] {10,4,2,10};
        Assert.AreEqual(LastStoneWeight(x), 2);
    }
}