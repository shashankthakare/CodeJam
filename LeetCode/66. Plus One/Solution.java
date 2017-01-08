public class Solution {
    public int[] plusOne(int[] digits) {
        
        int len = digits.length-1;
        
        for(int i = len; i>=0; i--){
            if(digits[i]==9){
            
                digits[i]=0;
                 
            }
            else{
                
                digits[i]++;
                break;
                
            }
            
        }
       
        if(digits[0]==0){
            
                int[] biggerNumber = new int[digits.length+1];
                biggerNumber[0]=1;
                return biggerNumber;
                
            }
            
        return digits;
    }
}