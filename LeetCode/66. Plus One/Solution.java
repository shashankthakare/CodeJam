public class Solution {
    public int[] plusOne(int[] digits) {
        
        int sum = 0;
        
        for(int i=0;i<digits.length;i++){
            sum = sum*10 + digits[i];
        }
        
        sum+=1;
        
        int length = Integer.toString(sum).length();
        int[] result = new int[length];
        
        while(sum>0)
        {
            result[--length] = sum%10;
            sum/=10;
        }
        return result;
    }
}