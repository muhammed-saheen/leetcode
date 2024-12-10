public class Solution {
    public int[] SortByBits(int[] arr) {
    return arr.OrderBy(x => Convert.ToString(x, 2).Count(c => c == '1'))
                  .ThenBy(x => x)  
                  .ToArray();       
    }
}