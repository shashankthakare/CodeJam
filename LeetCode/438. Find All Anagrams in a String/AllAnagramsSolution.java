package testProject;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class AllAnagramsSolution {
	
	public static int ALPHABET = 26;
	
	public boolean isAnagram(String s, String t) {
		
		if(s.length()!=t.length())
			return false;
		
		int[] String1 = new int[ALPHABET];
		int[] String2 = new int[ALPHABET];
        
		String1 = characterCount(s);
        String2 = characterCount(t);
       
		for(int i=0; i<String1.length; i++){
			if(String1[i]-String2[i]!=0)
				return false;
		}
        return true;
    }
	
	public int[] characterCount(String s){
		int[] countArray = new int[ALPHABET];
		int offset;
		for(int i=0; i<s.length();i++){
			offset = s.charAt(i)-'a';
			countArray[offset]++;
		}
		return countArray; 
	}
	
	public List<Integer> findAnagrams(String s, String p) {
		List<Integer> arr = new ArrayList<Integer>();
		for(int j=0; j<(s.length()-p.length()); j++){
			if(isAnagram(s.substring(j, j+p.length()-1),p))
				arr.add(j);
		}
		return arr;
	}
	
	public static void main(String[] args){
		AllAnagramsSolution sol = new AllAnagramsSolution();
		System.out.println(sol.findAnagrams("cbaebabacd","abc"));
	}
}
