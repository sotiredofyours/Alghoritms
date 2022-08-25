namespace ConsoleApp1.leetCode._150._Evaluate_Reverse_Polish_Notation;

public class EvaluatePolish
{
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();
        foreach (var token in tokens)
        {
            int secondOp;
            int firstOp;
            switch (token)
            {
                case "+":
                    secondOp = stack.Pop();
                    firstOp = stack.Pop();
                    stack.Push(firstOp+secondOp);
                    break;
                case "-":
                    secondOp = stack.Pop();
                    firstOp = stack.Pop();
                    stack.Push(firstOp-secondOp);
                    break;
                case "/":
                    secondOp = stack.Pop();
                    firstOp = stack.Pop();
                    stack.Push(firstOp/secondOp);
                    break;
                case "*":
                    secondOp = stack.Pop();
                    firstOp = stack.Pop();
                    stack.Push(firstOp*secondOp);
                    break;
                default:
                    stack.Push(int.Parse(token));
                    break;
            }
        }

        return stack.Peek();
    }
}