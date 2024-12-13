public class Solution {
    public void SortColors(int[] nums) {
        int temp;
        for (int i=0;i<nums.Length;i++){
            for (int j=i+1;j<nums.Length;j++){
                if(nums[i]>nums[j]){
                    temp=nums[i];
                    nums[i]=nums[j];
                    nums[j]=temp;
                }
            }
        }
    }
}