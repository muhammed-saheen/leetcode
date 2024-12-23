public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        List<int> result = new List<int>();
        for (int i = 0; i < nums1.Length; i++) {
            int current = nums1[i];
            bool found = false;
            bool flag = false;
            for (int j = 0; j < nums2.Length; j++) {
                if (nums2[j] == current) {
                    found = true; 
                }
                if (found && nums2[j] > current) {
                    result.Add(nums2[j]);
                    flag = true;
                    break;
                }
            }
            if (!flag) {
                result.Add(-1);
            }
        }

        return result.ToArray();
    }
}
