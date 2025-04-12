public class Solution {
    public int MinOperations(int[] nums, int k) {
        HashSet<int> st = new HashSet<int>(nums);
        int count =0;
        foreach(var item in st){
            if(item<k){
                return -1;
            }
            if(item>k){
                count ++;
            }
        }
        return count ;
    }
}