//partial solution. passed 21/23 test cases
public class Solution {
    public boolean containsNearbyDuplicate(int[] nums, int k) {
        HashMap<Integer,Integer> hmap = new HashMap<Integer,Integer>();
        for(int i=0;i<nums.length;i++){
            if(hmap.get(nums[i])==null)
                hmap.put(nums[i],i);
            else{
                if(i-hmap.get(nums[i])<=k)
                return true;
            }
        }
        return false;
    }
}