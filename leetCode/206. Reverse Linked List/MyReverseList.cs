namespace ConsoleApp1.leetCode._206._Reverse_Linked_List;

public class MyReverseList
{
    public class ListNode {
         public int val;
             public ListNode next;
             public ListNode(int val=0, ListNode next=null) {
                 this.val = val;
                 this.next = next;
             }
     }
    public ListNode ReverseList(ListNode head)
    {
        return Helper(head, null);
    }

    ListNode Helper(ListNode head, ListNode newHead)
    {
        if (head == null) return newHead;
        else
        {
            var next = head.next;
            head.next = newHead;
            return Helper(next, head);
        }
    }
}