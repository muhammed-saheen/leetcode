public class Solution {
    public string SortVowels(string s) {
        List<char> ls =new List<char>();
        StringBuilder str= new StringBuilder(s);
        for(int i=0;i<s.Length;i++){
          if("aeiouAEIOU".Contains(s[i])){
            ls.Add(s[i]);
          }
        }
        ls.Sort();
        int j = 0;
        for(int i=0;i<s.Length;i++){
            if("aeiouAEIOU".Contains(s[i])){
                str[i]=ls[j++];
            }
        }
        return str.ToString();
    }
}