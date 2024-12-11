public class Solution {
    public int ScoreOfString(string s) {
        List<int> ls =new List<int>();
        for(int i=0;i<s.Length-1;i++){
         ls.Add(Math.Abs(s[i]-s[i+1]));
        }
        return ls.Sum();
    }
}