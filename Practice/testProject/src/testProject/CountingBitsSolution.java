package testProject;

import java.util.Arrays;

public class CountingBitsSolution {
	public int[] countBits(int num) {
        int[] array = new int[num+1];
        array[0]=0;
		for(int i=1; i<=num; i++){
			array[i]=Integer.bitCount(i);
		}
        return array;
    }
	
	public static void main(String[] args){
		CountingBitsSolution sol = new CountingBitsSolution();
		System.out.println(Arrays.toString(sol.countBits(5)));
	}
	
}
