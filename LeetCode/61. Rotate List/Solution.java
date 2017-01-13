/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode rotateRight(ListNode head, int k) {
        
        if(head==null)
            return head;
        
        ListNode returnNode = new ListNode(0);
            returnNode.next = head;
        
        ListNode traverseLength = returnNode;
        ListNode breakPoint = returnNode;
        
        //get the length of the node
        int length = 0;
        for(length=0; traverseLength.next!=null; length++)
            traverseLength = traverseLength.next;
        
        int breakingIndex = length - (k%length);
        //find the breaking point
        for(int i=0; i<breakingIndex; i++)
            breakPoint = breakPoint.next;
        
        //connect last node to first node
        traverseLength.next = returnNode.next;
        //point breaking node to return node
        returnNode.next = breakPoint.next;
        breakPoint.next = null;
        
        return returnNode.next;
    }
}