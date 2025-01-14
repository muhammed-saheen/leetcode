public class Solution {
    public bool IsAcronym(IList<string> words, string s) {
        StringBuilder str= new StringBuilder();
        for(int i=0;i<words.Count;i++){
        str.Append(words[i][0]);
        }
        if(str.ToString()==s){
            return true ;
        }
        return false ;
    }
}