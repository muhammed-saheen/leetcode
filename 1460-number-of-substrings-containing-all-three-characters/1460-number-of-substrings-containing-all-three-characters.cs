public class Solution {
    public int NumberOfSubstrings(string s) {
        int left = 0, count = 0;
        Dictionary<char, int> dic = new Dictionary<char, int>() {
            {'a', 0}, {'b', 0}, {'c', 0}
        };

        for (int right = 0; right < s.Length; right++) {
            dic[s[right]]++;

            while (dic['a'] > 0 && dic['b'] > 0 && dic['c'] > 0) {
                count += s.Length - right; 
                dic[s[left]]--;
                left++; 
            }
        }

        return count;
    }
}
