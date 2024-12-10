public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var list =new HashSet<int>(nums);
        if (list.Count==nums.Length){
            return false;
        }
        return true ;
    }
}