public class Solution {
    public List<Integer> findDuplicates(int[] nums) {
        
        List<Integer> duplicateNumbers = new ArrayList();
        
        for(int i=0; i<nums.length; i++){
          
            if(nums[Math.abs(nums[i])-1]<0)
                duplicateNumbers.add(Math.abs(nums[i]));
        
            else
                nums[Math.abs(nums[i])-1]*=-1;
        
            
        }
        
        return duplicateNumbers;
        
    }
}