namespace ConsoleApp1.leetCode._326._Power_of_Three;

public class PowerOfThree
{
    public bool IsPowerOfThree(int n) {
        if (n < 1) {
            return false;
        }

        while (n % 3 == 0) {
            n /= 3;
        }

        return n == 1;
    }
}