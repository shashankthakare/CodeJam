public class Solution {
    public int[] singleNumber(int[] nums) {
        
        int XOR = 0;
        
        int[] uniqueElements = {0,0};
        
        //gets the XOR of both unique elements
        for(int i=0; i<nums.length; i++){
            XOR^=nums[i];
        }
        
        // this will fetch the last set bit
        XOR&=-XOR; 
        
        for(int i=0; i<nums.length;i++){
/* current number has its bit zero on (last set bit)'s place of XOR
The unique numbers will thus get XORed with different numbers in uniqueElements
The clones will cancel each other as they will be XORed to either uniqueElements[0]
or uniqueElements[1]*/
            if((nums[i] & XOR) == 0)
                uniqueElements[0] ^= nums[i];
            
            else
                uniqueElements[1] ^= nums[i];
        }   
        
        return uniqueElements;
    }
}