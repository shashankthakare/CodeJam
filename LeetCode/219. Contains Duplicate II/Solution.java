public class Solution {
    public boolean containsNearbyDuplicate(int[] nums, int k) {
        HashMap<Integer,Integer> hmap = new HashMap<Integer,Integer>();
        boolean isPossible=false;
        for(int i=0;i<nums.length;i++){
            if(hmap.get(nums[i])==null)
                hmap.put(nums[i],i);
            else{
                if(i-hmap.get(nums[i])<=k)
                    isPossible = true;
                else
                    hmap.put(nums[i],i);
            }
        }
        return isPossible;
    }
}