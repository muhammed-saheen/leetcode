public class Solution {
    public int[] VowelStrings(string[] words, int[][] queries) {
        int n = words.Length;
        int[] prefix = new int[n + 1];
        for (int i = 0; i < n; i++) {
            if ("aeiou".Contains(words[i][0]) && "aeiou".Contains(words[i][words[i].Length - 1])) {
                prefix[i + 1] = prefix[i] + 1;
            } else {
                prefix[i + 1] = prefix[i];
            }
        }

        List<int> ls = new List<int>();
        foreach (var query in queries) {
            int li = query[0];
            int ri = query[1];
            ls.Add(prefix[ri + 1] - prefix[li]);
        }

        return ls.ToArray();
    }
}



