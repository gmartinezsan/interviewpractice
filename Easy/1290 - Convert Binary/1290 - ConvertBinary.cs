/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

// Time complexity O(N) where n is the number of nodes
// Space complexity O(1) only the extra node and the string 
// https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
// Solution
// traverse the list and accumulate the numbers in a string
// convert the string to a decimal number


public class Solution {
    public int GetDecimalValue(ListNode head) {
        
        if (head == null)
            return 0;
        
        string n = String.Empty;
        ListNode current = head;
        
        while(current != null)
        {
            n += current.val;
            current = current.next;
        }
        
        return Convert.ToInt32(n, 2);
    }
}