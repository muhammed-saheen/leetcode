public class Solution {
    public string KthDistinct(string[] arr, int k) {
            var d = arr.GroupBy(x => x)   
           .Where(g => g.Count() == 1)    
           .Select(g => g.Key)   
           .ToArray();       
           
            if (k>d.Length){
            return "";
             }
            else {
            return d[k - 1].ToString();   
            }
    }
}