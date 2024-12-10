public class Solution {
    public int HammingWeight(int n) {
        string bin=Convert.ToString(n,2);
        int counter=0;
        foreach (char s in bin){
            if (s=='1'){
                counter ++;
            }
        }
        return counter;
    }
}