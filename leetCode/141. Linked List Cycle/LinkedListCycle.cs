namespace ConsoleApp1.leetCode._141._Linked_List_Cycle;

public class LinkedListCycle
{
    public class ListNode {
         public int val;
             public ListNode next;
             public ListNode(int x) {
                val = x;
                next = null;
        }
     }
    public bool HasCycle(ListNode head)
    {
        var slow = head;
        var fast = head;
        while (fast!=null)
        {
            
            slow = slow.next;
            fast = fast.next.next;
            if (fast == slow) return true;
        }

        return true;
    }
}