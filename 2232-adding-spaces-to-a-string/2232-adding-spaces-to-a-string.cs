public class Solution {
    public string AddSpaces(string s, int[] spaces) {
       var new_s=new StringBuilder();
       var index=0;
       for(int i=0;i<s.Length;i++){
            if (index < spaces.Length && i == spaces[index]) {
            new_s.Append(' ');
            index++;
        }
        new_s.Append(s[i]);
        
       }
       return new_s.ToString();
    }
}