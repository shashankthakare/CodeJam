import java.util.Arrays;

public class Solution {

	public int coinChange(int[] coins, int amount) {
    	int[] solnArray = new int[amount+1];
    	Arrays.fill(solnArray, (Integer.MAX_VALUE-1));
    	solnArray[0]=0;
    	
    	for(int j=0; j<coins.length; j++){
    		
    		for(int i=1; i <= amount; i++){
    			
    			if(i>=coins[j]){
    				solnArray[i] = Math.min(solnArray[i], 1+(solnArray[i- coins[j]]));
    			}
    			
    		}
    		
    	}
    	if(solnArray[amount]!=(Integer.MAX_VALUE-1))
    		return solnArray[amount];
    	else
    		return -1;
    }
    
    public static void main(String[] args){
    	int[] coins = {1,2,5};
    	int amount = 11;
    	Solution sol= new Solution();
    	System.out.println("Minimum steps are "+sol.coinChange(coins, amount));
    }
}