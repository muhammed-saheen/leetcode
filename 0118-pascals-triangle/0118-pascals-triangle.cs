public class Solution {
    public IList<IList<int>> Generate(int numRows) {
    IList<IList<int>> items = new List<IList<int>>();
     for(int i=0;i<numRows;i++){
        List<int> sub = new List<int>();
        for (int j=0;j<=i;j++){
          if (j==0 || j==i ){
          sub.Add(1);
          }
          else {
            sub.Add(items[i - 1][j - 1] + items[i - 1][j]);
          }
        }
     items.Add(sub);

     } 
     return items;  
    }
}