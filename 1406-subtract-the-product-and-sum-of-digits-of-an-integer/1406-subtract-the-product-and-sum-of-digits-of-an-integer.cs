public class Solution {
    public int SubtractProductAndSum(int n) {
        string num=n.ToString();
        int mult=1;
        int sum=0;
        foreach(char nu in num){
          sum=sum+(nu-'0');
          mult=mult*(nu-'0');
        }
        return mult-sum;
    }
}