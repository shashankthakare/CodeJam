public class Solution {
    public boolean isPowerOfThree(int n) {
        //1162261467 is the larget known integer that is power of 3
        return n>0 && (1162261467%n==0);
    }
}