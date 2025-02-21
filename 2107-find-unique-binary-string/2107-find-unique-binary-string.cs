public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
        StringBuilder str= new StringBuilder();
        for(int i=0;i<nums.Length;i++){
            if(nums[i][i]=='0'){
                str.Append(1);
            }
           else {
            str.Append(0);
           }
           
        }
        return str.ToString();
    }
}