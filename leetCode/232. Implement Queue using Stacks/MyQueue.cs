namespace ConsoleApp1.leetCode._232._Implement_Queue_using_Stacks;

public class MyQueue
{
    Stack<int> onPush;
    Stack<int> onPop;
    public MyQueue() {
        onPush = new Stack<int>();
        onPop = new Stack<int>();
    }
    
    public void Push(int x) {
        while(onPop.Count!=0){
            onPush.Push(onPop.Pop());
        }
        onPush.Push(x);
    }
    
    public int Pop() {
        
        while(onPush.Count!=0){
            onPop.Push(onPush.Pop());
        }
        
        return onPop.Pop();
    }
    
    public int Peek() {
        while(onPush.Count!=0){
            onPop.Push(onPush.Pop());
        }
        return onPop.Peek();
        
    }
    
    public bool Empty() {
        return onPush.Count == 0 && onPop.Count == 0;
    }
}