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
 public List < Integer > inorderTraversal(TreeNode root) {

  List < Integer > result = new ArrayList < > ();
  Stack < TreeNode > stack = new Stack < > ();

  TreeNode currentNode = root;

  while (!stack.isEmpty() || currentNode != null) {

   if (currentNode != null) {

    stack.push(currentNode);
    currentNode = currentNode.left;

   } else {

    currentNode = stack.pop();
    result.add(currentNode.val);

    currentNode = currentNode.right;

   }
  }
  return result;
 }
}