public class Solution {
    public bool IsBalanced(string num) {
        int odd=0;
        int even=0;
        for(int i=0;i<num.Length;i++){
            int digit =num[i]-'0';
            if(i%2==0){
                even=even+digit;
            }
            else {
                odd=odd+digit;
            }
        }
        if(even==odd){
            return true ;
        }
        return false ;
    }
}