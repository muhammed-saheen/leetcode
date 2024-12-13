public class Solution {
    public bool IsPalindrome(int x) {
        if(x.ToString()==new String(x.ToString().Reverse().ToArray())){
            return true;
        }
        else {
            return false ;
        }
    }
}