public class Solution {
    public string RestoreString(string s, int[] indices) {
        StringBuilder ls=new StringBuilder(s);
        for(int i=0;i<indices.Length;i++){
            ls[indices[i]]=s[i];
        } 
        return ls.ToString();
    }
}