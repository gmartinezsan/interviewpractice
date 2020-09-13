/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }

https://leetcode.com/problems/range-sum-of-bst/
Time Complexity: O(N), where N is the number of nodes in the tree.
Space Complexity: O(H), where H is the height of the tree.
 */

public class Solution {
    public int RangeSumBST(TreeNode root, int L, int R) {
        if (root == null)
            return 0;
        
        return GetSum(root, L, R, 0);
    }
    
    public int GetSum(TreeNode node, int L, int R, int sum)
    {
        if(node == null)
            return sum;
        
        if (L <= node.val && node.val <= R)
            sum += node.val;
        
         if (node.val > L)
            sum = GetSum(node.left, L, R,sum);
        
        if (node.val < R)
            sum = GetSum(node.right, L, R,sum);
        
        return sum;
    }
        
}


