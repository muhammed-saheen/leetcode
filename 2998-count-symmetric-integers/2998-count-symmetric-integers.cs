public class Solution {
    public int CountSymmetricIntegers(int low, int high) {
        int count=0;
        for(int i=low ;i<=high;i++){
            string n=i.ToString();
            if(n.Length%2==0){
            int mid =n.Length/2;
            int s1=0;
            int s2=0;
            for(int j=0;j<mid;j++){
             s1=s1+n[j]-'0';
            }
            for(int k=mid;k<n.Length;k++){
             s2=s2+n[k]-'0';
            }
            if(s1==s2){
            count++;
            }

            }
        }
        return count ;
    }
}