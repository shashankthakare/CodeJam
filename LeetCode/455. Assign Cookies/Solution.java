public class Solution {
    public int findContentChildren(int[] g, int[] s) {
        Arrays.sort(g);
        Arrays.sort(s);
        
        int satisfiedChildren=0;
        
        for(int cookie=0; cookie<s.length && satisfiedChildren<g.length; cookie++){
        
            if(g[satisfiedChildren]<=s[cookie])
                satisfiedChildren++;
        
            
        }
        
        return satisfiedChildren;
        
    }
}