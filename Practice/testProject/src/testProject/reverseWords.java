package testProject;

public class reverseWords {
	public String reverseWords2(String s) {
		String[] parts = s.trim().split("\\s+");
		String out = "";
		for (int i = parts.length - 1; i > 0; i--) {
		    out += parts[i] + " ";
		}
		return out + parts[0];
	}
	
	public String reverseWords1(String s) {
	        
	        String[] parts = s.split("\\s+");
	        StringBuilder sb = new StringBuilder();
	        
	        for(int i = parts.length-1; i>=0; i--){
	            sb.append(parts[i]+" ");    
	        }
	        
	        return sb.toString().trim();
	        
	    }
	 
	public static void main(String args[]){
		reverseWords rw = new reverseWords();
		System.out.println(rw.reverseWords2("   a   b "));
		System.out.println(rw.reverseWords1("   a   b "));
	}
}
