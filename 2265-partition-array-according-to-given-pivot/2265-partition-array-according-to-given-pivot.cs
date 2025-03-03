

public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        List<int> ls1 = new List<int>();
        List<int> ls2 = new List<int>();
        List<int> eq = new List<int>();

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] < pivot) {
                ls1.Add(nums[i]);
            }else if(nums[i]==pivot){
                eq.Add(nums[i]);
            }
             else {
                ls2.Add(nums[i]);
            }
        }

        
        return ls1.Concat(eq).Concat(ls2).ToArray();
    }
}
