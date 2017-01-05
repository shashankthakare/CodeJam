//Linear solution. TLE for huge inputs
public class Solution {
    public int rangeBitwiseAnd(int m, int n) {
        int a = m;
        for(int i=m+1; i<=n; i++){
            a&=i;
        }
        return a;
    }
}