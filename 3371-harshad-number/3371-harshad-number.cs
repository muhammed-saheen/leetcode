public class Solution {
    public int SumOfTheDigitsOfHarshadNumber(int x) {
        int sum=0;
        int rem;
        int original = x;
        while(x>0){
            rem=x%10;
            sum=sum+rem;
            x=x/10;
        }
        if(original%sum==0){
            return sum ;

        }
        return -1 ;

    }
}