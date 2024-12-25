public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        List<bool> ls = new List<bool>();
        for(int i=0;i<candies.Length;i++){
          if((candies[i]+extraCandies)>=candies.Max()){
            ls.Add(true);
          }else {
          ls.Add(false);
          }
        }
        return ls;
    }
}