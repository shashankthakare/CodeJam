package testProject;

import java.util.Arrays;

public class Solution {
	public int[] countBits(int num) {
        int[] array = new int[num+1];
        array[0]=0;
		for(int i=1; i<=num; i++){
			array[i]=Integer.bitCount(i);
		}
        return array;
    }
	
}
