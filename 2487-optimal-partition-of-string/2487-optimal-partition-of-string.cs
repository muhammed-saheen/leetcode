public class Solution {
    public int PartitionString(string s) {
        int counter=1;
        HashSet<char> ls =new HashSet<char>();
        for(int i=0;i<s.Length;i++){
        if(ls.Contains(s[i])){
             counter++;
             ls.Clear();
        }
        ls.Add(s[i]);
        }
        return counter;
    }
}