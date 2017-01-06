//needs work.
public class Solution {
    public int majorityElement(int[] nums) {
        
        int count = 0; 
        int mask = 1; 
        int majority = 0;
        
        for(int i = 0; i < 32; ++i) {
            
            count = 0;
            
            for(int j = 0; j < nums.length; ++j)
                //increment if current bit is set
                if((mask & nums[j])==1) 
                    count++;
            
            if(count > nums.length/2) 
                majority |= mask;
                
            mask <<= 1;
        }
        return majority;
    }
}