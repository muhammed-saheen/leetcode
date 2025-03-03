public class Solution {
    public int[][] MergeArrays(int[][] nums1, int[][] nums2) {
        List<int []> ls = new List<int []>();
         int i=0;
         int j=0;
        while (i < nums1.Length && j < nums2.Length) {
            if (nums1[i][0] == nums2[j][0]) {
                ls.Add(new int[] { nums1[i][0], nums1[i][1] + nums2[j][1] });
                i++;
                j++;
            } 
            else if (nums1[i][0] < nums2[j][0]) {
                ls.Add(nums1[i]);
                i++;
            } 
            else {
                ls.Add(nums2[j]);
                j++;
            }
        }

         while (i < nums1.Length) {
            ls.Add(nums1[i]);
            i++;
        }

        while (j < nums2.Length) {
            ls.Add(nums2[j]);
            j++;
        }

        return ls.ToArray();
    }
}