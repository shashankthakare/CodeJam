package linkedList;
public class LinkedList {

	Node head;
	
	class Node{
		int data;
		Node next;
		Node(int d) {
				data = d;
				next = null;
			}
	}
	
	public void push(int d){
		Node newNode = new Node(d);
		newNode.next = head;
		head = newNode;
	}
	
	void printReverse(Node head){
		if(head==null){
			//System.out.println("head is null");
			return;
		}
		printReverse(head.next);
		
		System.out.print(head.data+" ");
		
	}
	
	public static void main(String args[]){
		//push to list and print
		LinkedList llist = new LinkedList();
		llist.push(4);
		//System.out.println("llist 4 returned");
		llist.push(3);
		//System.out.println("llist 3 returned");
		llist.push(2);
		//System.out.println("llist 2 returned");
		llist.push(1);
		//System.out.println("llist 1 returned");
		//call reverse
		llist.printReverse(llist.head);
		//System.out.println("printReverse returned");
	}
}
