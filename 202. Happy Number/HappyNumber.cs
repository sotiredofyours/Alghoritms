using NUnit.Framework;

namespace ConsoleApp1._202._Happy_Number;

public class HappyNumber
{
    public bool IsHappy(int n)
    {
        var hash = new HashSet<int>();
        var sum = 0;
        while (true)
        {
            sum = 0;
            while (n > 0)
            {
                var x = n % 10;
                sum += x*x;
                n /= 10;
            }
            if (hash.Contains(sum)) return false;
            if (sum == 1) return true;
            hash.Add(sum);
            n = sum;
        }
    }

    [Test]
    public void test()
    {
        var x = IsHappy(19);
        Assert.AreEqual(x, true);
    }
    
}