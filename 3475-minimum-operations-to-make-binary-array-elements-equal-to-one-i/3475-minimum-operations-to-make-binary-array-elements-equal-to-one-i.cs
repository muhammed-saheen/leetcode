public class Solution {
    public int MinOperations(int[] nums) {
        int count =0;
        for(int i=0;i<nums.Length-2;i++){
            if(nums[i]==0){
              nums[i]=1;
              nums[i+1]=nums[i+1]^1;
              nums[i+2]=nums[i+2]^1;
              count++;
            }else {
                continue ;
            }
        }
        if(nums[nums.Length-1]==0|| nums[nums.Length-2]==0){
         count =-1;
        }
        return count ;
    }
}