using ConsoleApp1._19._Remove_Nth_Node_From_End_of_List;

namespace ConsoleApp1._234._Palindrome_Linked_List;

public class PalindromeLinkedList
{
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
    public bool IsPalindrome(ListNode head)
    {
        var list = new List<int>();
        var helpNode = head;
        while (helpNode!=null)
        {
            list.Add(helpNode.val);
            helpNode = helpNode.next;
        }
        var l = 0;
        var r = list.Count - 1;
        while (l<=r)
        {
            if (list[l] != list[r]) return false;
            l++;
            r--;
        }
        return true;
    }
}