public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        string [] code ={".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        string alphabet="abcdefghijklmnopqrstuvwxyz";
        HashSet<string> st = new HashSet<string>();
        for(int i=0;i<words.Length;i++){
            StringBuilder str=new StringBuilder();
            for(int j=0;j<words[i].Length;j++){
                int index =alphabet.IndexOf(words[i][j]);
                str.Append(code[index]);
            }
            st.Add(str.ToString());
        }
        return st.Count();
    }
}