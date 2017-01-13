public class Solution {
    public int removeDuplicates(int[] nums) {
        
        int finalCount = 0;
        
        for (int i=0; i<nums.length; i++){
        //if current number is greater than its previous numbers, then overwrite it to finalcount index    
            if (finalCount < 2 || nums[i] > nums[finalCount-2])
            
                nums[finalCount++] = nums[i];
            
        }
        return finalCount;
    }
}