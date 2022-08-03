namespace ConsoleApp1._19._Remove_Nth_Node_From_End_of_List;

public class RemoveNode
{
    public class ListNode {
             public int val;
             public ListNode next;
             public ListNode(int val=0, ListNode next=null) {
                 this.val = val;
                 this.next = next;
             }
     }
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode fast = head;
        ListNode slow = head;   
        int length = 0;
        while (fast!=null)
        {
            length++;
            fast = fast.next;
        }
        if (length == 1) return null;
        if (length == n) {
            head = head.next;
            return head;
        }
        int curLength = 0;
        while (curLength!=length-n-1 )
        {
            curLength++;
            slow = slow.next;
        }

        slow.next = slow.next.next;
        return head;
    }
}