public class Solution {
    public bool CheckIfExist(int[] arr) {
        for(int i=0;i<arr.Length;i++){
            bool flag=false ;
            for(int j=i+1;j<arr.Length;j++){
               if(arr[i]==2*arr[j]||arr[j]==2*arr[i]){
                return true ;
               }
            }
        }
        return false ;
    }
}