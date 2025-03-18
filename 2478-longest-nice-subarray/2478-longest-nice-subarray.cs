public class Solution {
    public int LongestNiceSubarray(int[] nums) {
        int left = 0, orSum = 0, maxLength = 0;

        for (int right = 0; right < nums.Length; right++) {
            while ((orSum & nums[right]) != 0) {
                orSum ^= nums[left];
                left++;
            }

            orSum |= nums[right];
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
        }
}