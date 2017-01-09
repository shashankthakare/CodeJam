public class NaiveSolution {
    public int singleNumber(int[] nums) {
        HashMap<Integer,Integer> hmap = new HashMap<Integer,Integer>();
        for(int i=0; i<nums.length; i++){
            if(!hmap.containsKey(nums[i]))
                hmap.put(nums[i],1);
            else
                hmap.put(nums[i],hmap.get(nums[i]+1);
        }
        
    }
}