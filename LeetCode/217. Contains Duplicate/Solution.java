public class Solution {
    public boolean containsDuplicate(int[] nums) {
        HashMap<Integer,Integer> hmap = new HashMap<Integer,Integer>();
        for(int i=0;i<nums.length;i++){
            if(hmap.get(nums[i])==null)
                hmap.put(nums[i],1);
            else
                return true;
        }
        return false;
    }
}