using System;
using System.Collections.Generic;

public class Solution {
    public long CountOfSubstrings(string word, int k) {
        int n = word.Length;
        // Precompute prefix sum: prefix[i+1] = number of consonants in word[0...i]
        int[] prefix = new int[n + 1];
        HashSet<char> vowelsSet = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };
        for (int i = 0; i < n; i++) {
            prefix[i + 1] = prefix[i] + (vowelsSet.Contains(word[i]) ? 0 : 1);
        }
        
        // Last occurrence for each vowel; initialize to -1 (not seen)
        Dictionary<char, int> lastOccurrence = new Dictionary<char, int>() {
            {'a', -1},
            {'e', -1},
            {'i', -1},
            {'o', -1},
            {'u', -1}
        };
        
        long ans = 0;
        // This pointer tracks indices (for l) that are valid (l <= current m)
        int validPointer = 0;
        // Frequency dictionary for prefix sums at valid indices
        Dictionary<int, long> freq = new Dictionary<int, long>();
        
        for (int r = 0; r < n; r++) {
            char c = word[r];
            if (lastOccurrence.ContainsKey(c)) {
                lastOccurrence[c] = r; // update last occurrence if c is a vowel
            }
            
            // Determine the smallest last occurrence among all vowels.
            int m = int.MaxValue;
            foreach (char v in new char[]{'a', 'e', 'i', 'o', 'u'}) {
                if (lastOccurrence[v] == -1) {
                    m = -1;
                    break;
                }
                m = Math.Min(m, lastOccurrence[v]);
            }
            // If not all vowels have been seen, skip this r.
            if (m == -1) continue;
            
            // Extend valid l indices up to m (they are now “active” for substrings ending at r)
            while (validPointer <= m) {
                int key = prefix[validPointer];
                if (!freq.ContainsKey(key))
                    freq[key] = 0;
                freq[key]++;
                validPointer++;
            }
            
            // For substring [l, r] to have exactly k consonants, we need:
            // prefix[r+1] - prefix[l] == k  =>  prefix[l] == prefix[r+1] - k.
            int target = prefix[r + 1] - k;
            if (freq.ContainsKey(target))
                ans += freq[target];
        }
        
        return ans;
    }
}
