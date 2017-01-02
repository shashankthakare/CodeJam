/**
 * Definition for singly-linked list.
 * class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public boolean hasCycle(ListNode head) {
         if(head==null)return false;
    
        ListNode fast= head.next;
        ListNode slow= head;
    
    
        while(slow!=null&&fast!=null&&fast.next!=null){ 
//if any next pointer is null, means end is reached and there is no loop
        if(slow == fast)
            return true;
        
        fast=fast.next.next;
        slow=slow.next;
        
    }   
    return false;
    }
}