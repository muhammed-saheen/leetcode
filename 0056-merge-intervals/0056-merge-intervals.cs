

public class Solution {
    public int[][] Merge(int[][] intervals) {
        intervals = intervals.OrderBy(a => a[0]).ToArray();
        
        List<int[]> result = new List<int[]>();
        
        int[] currentInterval = intervals[0];
        result.Add(currentInterval);
        
        foreach (var interval in intervals) {
            if (currentInterval[1] >= interval[0]) {
                currentInterval[1] = Math.Max(currentInterval[1], interval[1]);
            } else {
                currentInterval = interval;
                result.Add(currentInterval);
            }
        }
        
        return result.ToArray();
    }
} 
