public class Solution {
    public long MaximumTripletValue(int[] nums) {
        if (nums.Length < 3) {
            return 0;
        }

        long maxTriplet = 0;
        
        for (int i = 0; i < nums.Length - 2; i++) {
            for (int j = i + 1; j < nums.Length - 1; j++) {
                long diff = nums[i] - nums[j];
                if (diff <= 0) continue;
                
                for (int k = j + 1; k < nums.Length; k++) {
                    long current = diff * nums[k];
                    if (current > maxTriplet) {
                        maxTriplet = current;
                    }
                }
            }
        }
        
        return maxTriplet;
    }
}