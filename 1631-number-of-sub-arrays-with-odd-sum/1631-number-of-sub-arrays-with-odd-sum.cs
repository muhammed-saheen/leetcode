public class Solution {
    public int NumOfSubarrays(int[] arr) {
        const int MOD = 1_000_000_007;
        int oddCount = 0, evenCount = 1; 
        int sum = 0, count = 0;

        foreach (int num in arr) {
            sum += num;

            if (sum % 2 != 0) {
                count = (count + evenCount) % MOD;
                oddCount++;
            } else {
                count = (count + oddCount) % MOD;
                evenCount++;
            }
        }

        return count;
    }
}
