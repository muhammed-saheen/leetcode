public class Solution {
    public int SingleNumber(int[] nums) {
        var  item= nums.GroupBy(x=>x).Where(x=>x.Count()==1).Select(x=>x.Key).Single();
        return item;
    }
}