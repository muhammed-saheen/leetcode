public class Solution {
    public int MaximumCandies(int[] candies, long k) {
        if (candies.Sum(x => (long)x) < k) return 0; 

        int left = 1, right = candies.Max(), result = 0;

        while (left <= right) {
            int mid = left + (right - left) / 2;
            long count = 0;

            foreach (int pile in candies) {
                count += pile / mid; 
            }

            if (count >= k) {
                result = mid; 
                left = mid + 1; 
            } else {
                right = mid - 1; 
            }
        }

        return result;
    }
}
