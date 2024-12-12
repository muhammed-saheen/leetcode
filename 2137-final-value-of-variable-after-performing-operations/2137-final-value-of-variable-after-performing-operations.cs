public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
      int x=0;
      foreach (String item in operations  ) {
        if (item=="--X" || item=="X--"){
            x--;
        }
        else if(item=="X++" || item=="++X"){
            x++;
        }
      }  
      return x;
    }
}