package testProject;

import java.util.Arrays;

public class removeDuplicatesSorted {
	public void removeDuplicates(int[] nums) {
        int index=0;
        for(int i=0; i<nums.length; i++){
            if(nums[i]!=0){
                nums[index++]=nums[i];
            }
        }
        
        for(int i=index; i<nums.length; i++)
        {
            nums[i]=0;
        }
        System.out.println(Arrays.toString(nums));
       
    }
	public static void main(String[] args){
		int[] nums={1,2,3,4};
		removeDuplicatesSorted sol = new removeDuplicatesSorted();
		sol.removeDuplicates(nums);
	}
}
