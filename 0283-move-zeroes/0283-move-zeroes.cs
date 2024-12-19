public class Solution {
    public void MoveZeroes(int[] nums) {
        int temp=0;
        for(int i=0;i<nums.Length;i++){
           if(nums[i]!=0){
            nums[temp]=nums[i];
            temp++;
           }
        }
        for(int i=temp;i<nums.Length;i++){
            nums[i]=0;
        }
    }
}