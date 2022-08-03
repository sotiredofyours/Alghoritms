namespace ConsoleApp1._43._Multiply_Strings;

public class MultiplyStrings
{
    public string Multiply(string num1, string num2)
    {
        var firstNumber = 0;
        var rank = 1;
        foreach (var ch in num1)
        {
            var x = ch - 48;
            firstNumber += x*rank;
        }

        return "";
    }
}