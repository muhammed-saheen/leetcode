public class Solution {
    public int CountCharacters(string[] words, string chars) {
        int len=0;
        for(int i=0;i<words.Length;i++){
            List<char> ls =chars.ToList();
            bool flag=true;
            for(int j=0;j<words[i].Length;j++){
                if(ls.Contains(words[i][j])){
                ls.Remove(words[i][j]);
                continue;
                }
                else{
                    flag=false;
                    break;
                }
            }
            if(flag==true){
                len=len+words[i].Length;
            }
        }
        return len;
    }
}