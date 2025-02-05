public class Solution {
    public int MinPairSum(int[] nums) {
        Array.Sort(nums); 
        int maxPairSum = 0;
        int n = nums.Length;
        for (int i = 0; i < n/2 ; i++) { 
            int pairSum = nums[i] + nums[n - 1 - i]; 
            maxPairSum = Math.Max(maxPairSum, pairSum);
        }
        return maxPairSum;
    }
}
