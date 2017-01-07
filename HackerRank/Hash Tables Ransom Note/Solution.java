import java.util.*;

public class Solution {
    HashMap<String, Integer> magazineMap = new HashMap<String, Integer>();
    
    public boolean solve(String magazine, String note) {
        
        String[] magazineParts = magazine.split(" ");
        String[] noteParts = note.split(" ");
        
        if(noteParts.length > magazineParts.length)
            return false;
        
        for(int i=0; i<magazineParts.length; i++){
            if(magazineMap.containsKey(magazineParts[i]))
                magazineMap.put(magazineParts[i],magazineMap.get(magazineParts[i])+1);
            else
                magazineMap.put(magazineParts[i],1);
        }
        
        for(int i=0; i<noteParts.length; i++){
            if(magazineMap.containsKey(noteParts[i])==false)
                return false;
            else{
                //check if its used or not
                if(magazineMap.get(noteParts[i])==0)
                    return false;
                else
                    magazineMap.put(noteParts[i],magazineMap.get(noteParts[i])-1);
            }
        }
        
        return true;
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int m = scanner.nextInt();
        int n = scanner.nextInt();
        
        // Eat whitespace to beginning of next line
        scanner.nextLine();
        String magazine, note;
        
        Solution s = new Solution();
        
        magazine = scanner.nextLine();
        note = scanner.nextLine();
        
        scanner.close();
        
        boolean answer = s.solve(magazine,note);
        if(answer)
            System.out.println("Yes");
        else System.out.println("No");
      
    }
}
