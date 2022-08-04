using NUnit.Framework;

namespace ConsoleApp1.leetCode._20._Valid_Parentheses;

public class ValidParenthses
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        foreach (var x in s)
        {
            if (x == '(' || x =='{' || x == '[') stack.Push(x);
            else
            {
                if (stack.Count==0) return false;
                if (stack.Peek() == '(' && x != ')') return false;
                if (stack.Peek() == '[' && x != ']') return false;
                if (stack.Peek() == '{' && x != '}') return false;
                stack.Pop();
            }
        }
        
        return stack.Count == 0;
    }

    
}