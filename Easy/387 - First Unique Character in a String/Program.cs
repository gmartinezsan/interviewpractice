/*
387. First Unique Character in a String
Easy

Given a string, find the first non-repeating character in it and return its index. If it doesn't exist, return -1.

Examples:

s = "leetcode"
return 0.

s = "loveleetcode"
return 2.
*/

public class Solution {
    public int FirstUniqChar(string s) {
        
        Dictionary<char, int> uniqueChars = new Dictionary<char, int>();
        HashSet<char> seenChars = new HashSet<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (seenChars.Add(s[i]))
            {
                uniqueChars.Add(s[i], i);
            }
            else
            {
                uniqueChars.Remove(s[i]);
            }
        }
        // For returning the key
        //return chars.Count() > 0 ? chars.OrderBy(kvp => kvp.Value).First().Key : '_';
        //return the value, in this key the index
        return uniqueChars.Count() > 0 ? uniqueChars.Min(kvp => kvp.Value) : -1;
    }
}