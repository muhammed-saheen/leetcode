public class Solution {
    public int NumberOfSubstrings(string s) {
        int left = 0, count = 0;
        Dictionary<char, int> dic = new Dictionary<char, int>() {
            {'a', 0}, {'b', 0}, {'c', 0}
        };

        for (int right = 0; right < s.Length; right++) {
            dic[s[right]]++; // Expand window by adding s[right]

            // Shrink window from left when all characters are present
            while (dic['a'] > 0 && dic['b'] > 0 && dic['c'] > 0) {
                count += s.Length - right; // Count all valid substrings
                dic[s[left]]--; // Shrink window
                left++; 
            }
        }

        return count;
    }
}
