public class Solution {
    public int rangeBitwiseAnd(int m, int n) {
        int distance = 0;
        while(m!=n){
            m>>=1;
            n>>=1;
            distance++;
        }
        return m<<distance;
    }
}