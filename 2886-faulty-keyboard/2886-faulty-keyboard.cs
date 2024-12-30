public class Solution {
    public string FinalString(string s) {
        List<char> ls = new List<char>();
        for(int i=0;i<s.Length;i++){
            if(s[i]=='i'){
                ls.Reverse();
            }else {
                ls.Add(s[i]);
            }
        }
  return new string(ls.ToArray());  
    }
}