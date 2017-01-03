public class Solution {
    public int getSum(int a, int b) {
        if(b==0)
        return a;
        
        int carry=(a&b)<<1;
        int addition=a^b;
        
        return getSum(addition, carry);
    }
}