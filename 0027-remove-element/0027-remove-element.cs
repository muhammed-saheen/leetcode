public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int j=0;

        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=val){
              nums[j]=nums[i];
              j++;
            }
         
        }
        for(int i=0;i<nums.Length-j;i++){
            Console.WriteLine(nums[i]);
        }
      return j;
    }
}