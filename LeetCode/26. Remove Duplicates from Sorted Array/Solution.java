public class Solution {
    public int removeDuplicates(int[] nums) {
        int newCount=0;
        for(int i=0; i<nums.length-1; i++){
            if(nums[i]!=nums[i+1]){
                nums[newCount++]=nums[i];
            }
        }
        if(nums.length!=0)
        nums[newCount++]=nums[nums.length-1];
        return newCount;
    }
}