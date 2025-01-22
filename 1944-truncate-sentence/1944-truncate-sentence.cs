public class Solution {
    public string TruncateSentence(string s, int k) {
        string [] arr =s.Split(" ");
        string [] ar =new string[k];
        for(int i=0;i<k;i++){
         ar[i]=arr[i];
        }
        return string.Join(" ",ar);
    }
}