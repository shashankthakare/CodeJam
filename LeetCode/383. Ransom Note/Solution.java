public class Solution {
    public boolean canConstruct(String ransomNote, String magazine) {
      
      int[] rnCount = new int[26];
      int[] mgCount = new int[26];
      
      rnCount=characterCount(ransomNote);
      mgCount=characterCount(magazine);
      
      for(int i=0; i<26; i++){
          if(rnCount[i]-mgCount[i]>0)
           return false;
      }
      
      return true;
    }
    
    public int[] characterCount(String s){
		int[] countArray = new int[26];
		int offset;
		for(int i=0; i<s.length();i++){
			offset = s.charAt(i)-'a';
			countArray[offset]++;
		}
		return countArray; 
	}
      
}