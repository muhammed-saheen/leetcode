public class Solution {
    public int Maximum69Number (int num) {
        var n= new StringBuilder(num.ToString());
        for(int i=0;i<n.Length;i++){
            if(n[i]=='6'){
                n[i]='9';
                break;
            }
        }
      return int.Parse(n.ToString());    }
}