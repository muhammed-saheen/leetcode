public class Solution {
    public int LargestAltitude(int[] gain) {
        int[] altitude = new int[gain.Length + 1];
        int temp=0;
        for(int i=0;i<gain.Length;i++){
            altitude[i]=gain[i]+temp;
            temp=altitude[i];
        }
        return altitude.Max() ;
    }
}