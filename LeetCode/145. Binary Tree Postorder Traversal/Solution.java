/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
 public List < Integer > postorderTraversal(TreeNode root) {
  
  LinkedList < Integer > result = new LinkedList < > ();
  Stack < TreeNode > stack = new Stack < TreeNode > ();
  
  TreeNode currentNode = root;
  
  while (!stack.isEmpty() || currentNode != null) {
  
   if (currentNode != null) {
  
    stack.push(currentNode);
    result.addFirst(currentNode.val); 
  
    currentNode = currentNode.right;
  
   } else {
  
    currentNode = stack.pop();
    currentNode = currentNode.left; 
  
   }
      
  }
  return result;
 }
}