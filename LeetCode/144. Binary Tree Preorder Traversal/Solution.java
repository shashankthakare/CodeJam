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
    public List<Integer> preorderTraversal(TreeNode root) {
        
        List<Integer> result = new ArrayList<>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        
        TreeNode currentNode = root;
        
        while(!stack.isEmpty() || currentNode != null) {
        
            if(currentNode != null) {
        
                stack.push(currentNode);
                result.add(currentNode.val);
        
                currentNode = currentNode.left;
        
            } else {
        
                currentNode = stack.pop();
                currentNode = currentNode.right;   
        
            }
        }
        return result;
    }
}