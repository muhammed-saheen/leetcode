public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
      return nums.GroupBy(x=>x).Where(x=>x.Count()>1).Select(x=>x.Key).ToArray(); 
    }
}