public class Solution {
    public int MissingNumber(int[] nums) {
        int item=0;
        Array.Sort(nums);
        for (int i=0;i<nums.Length;i++){
            if(nums[i]!=i){
                item=i;
                break;
            }
            item=nums.Length;
        }
        return item;
    }
}