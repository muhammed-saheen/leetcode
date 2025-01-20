public class Solution {
    public int DifferenceOfSum(int[] nums) {
        int elegantsum=0;
        int sum=0;
        int number;
        foreach(int n in nums){
            elegantsum=elegantsum+n;
            number=n;
            while(number>0){
                sum=sum+number%10;
                number=number/10;
            }
        }
        return elegantsum-sum;
    }
}