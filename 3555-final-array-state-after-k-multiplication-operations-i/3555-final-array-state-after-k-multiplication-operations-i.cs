public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {
        for(int i=0;i<k;i++){
             int minIndex = Array.IndexOf(nums, nums.Min());
            nums[minIndex] *= multiplier;
        }
        return nums ;
    }

}