public class Solution {
    public string FirstPalindrome(string[] words) {
        foreach(string s in words ){
            if (s==new String(s.Reverse().ToArray())){
                return s;
            }
        }
        return "";
    }
}