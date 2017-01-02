/*
Detect a cycle in a linked list. Note that the head pointer may be 'null' if the list is empty.

A Node is defined as: 
    class Node {
        int data;
        Node next;
    }
*/

boolean hasCycle(Node head) {
    
    if(head==null)return false;
    
    Node fast= head.next;
    Node slow= head;
    
    
    while(slow!=null&&fast!=null&&fast.next!=null){ 
//if any next pointer is null, means end is reached and there is no loop
        if(slow == fast)
            return true;
        
        fast=fast.next.next;
        slow=slow.next;
        
    }
    return false;
}
