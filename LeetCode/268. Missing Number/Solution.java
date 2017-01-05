public class Solution {
    public int missingNumber(int[] nums) {
        int val=0;
        for(int i=0; i< nums.length; ++i){
        	val^=i;
        	val^=nums[i];
        }
        return val^=nums.length;
    }
}