//incomplete solution
public class Solution {
    public List<Integer> findDisappearedNumbers(int[] nums) {
        HashMap<Integer,Integer> hmap = new HashMap<Integer,Integer>();
        List<Integer> missingNumbers = new ArrayList<Integer>();
        
        int count=0;
        
        for(int i=0;i<nums.length;i++){
            if(hmap.get(nums[i])==null)
                hmap.put(nums[i],1);
        }
        
    }
}