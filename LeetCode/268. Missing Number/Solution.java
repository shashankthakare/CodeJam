//This solution is incomplete
package testProject;

import java.util.Arrays;

public class MissingNumberSolution {
	
	public int missingNumber(int[] nums) {
	    int val=0;
        for(int i=0; i< nums.length; i++){
        	if(nums[i]!=i)
        		return i;
        	val=i;
        }
        return val+1;
    }
	
	public static void main(String[] args){
		int[] arr = new int[1];
		MissingNumberSolution sol = new MissingNumberSolution();
		System.out.println(sol.missingNumber(arr));
	}
	
}
