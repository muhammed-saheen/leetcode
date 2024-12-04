public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] merged = nums1.Concat(nums2).OrderBy(x => x).ToArray();
        int n = merged.Length;
        if (n % 2 == 0) {
            return (merged[n / 2 - 1] + merged[n / 2]) / 2.0;
        } else {
            return merged[n / 2];
        }
    }
}