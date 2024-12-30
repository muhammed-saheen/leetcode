public class Solution {
    public bool CheckIfPangram(string sentence) {
        string s="abcdefghijklmnopqrstuvwxyz";
        for(int i=0;i<s.Length;i++){
            if(!sentence.Contains(s[i])){
                return false ;
            }
        }
        return true ;
    }
}