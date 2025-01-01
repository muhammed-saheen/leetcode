public class Solution {
    public int CountDigits(int num) {
        string n=num.ToString();
        int count=0;
        for(int i=0;i<n.Length;i++){
            if(num%(n[i]-'0')==0){
              count++;
            }
        }
        return count ;
    }
}