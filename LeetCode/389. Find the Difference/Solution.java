public class Solution {
    public char findTheDifference(String s, String t) {
        char c=0;
        
        s=s.concat(t);
        
        for(int i=0; i<s.length(); i++)
        c^=s.charAt(i);
        
        return c;
    }
}