//does not handle large inputs
public class NaiveSolution {
    public String addBinary(String a, String b) {
        int ia = Integer.parseInt(a, 2);
        int ib = Integer.parseInt(b, 2);
        return Integer.toString(ia + ib,2);
    }
}