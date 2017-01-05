public class Solution {
    public int reverse(int x) {
        long reverse = 0;
        while(x!=0){
            reverse = reverse*10 + x%10;
            x/=10;
            //check for overflow
            if(reverse>Integer.MAX_VALUE||reverse<Integer.MIN_VALUE)
                return 0;
        }
        return (int)reverse;
    }
}