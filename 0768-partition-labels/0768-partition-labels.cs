public class Solution {
    public IList<int> PartitionLabels(string s) {
        int largeIndex = 0; 
        List<int> ls = new List<int>();
        Dictionary<char, int> lastIndexMap = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++) {
            lastIndexMap[s[i]] = i; 
        }
        int partitionStart = 0;
        for (int i = 0; i < s.Length; i++) {
            largeIndex = Math.Max(largeIndex, lastIndexMap[s[i]]);            
            if (i == largeIndex) { 
                ls.Add(largeIndex - partitionStart + 1);
                partitionStart = i + 1; 
            }
        }
        return ls;
    }
}
