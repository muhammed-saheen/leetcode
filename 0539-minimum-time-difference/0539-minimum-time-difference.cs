public class Solution {
    public int FindMinDifference(IList<string> timePoints) {
        var list = new List<int>();
        
        for (int i = 0; i < timePoints.Count; i++) {
            var time = timePoints[i].Split(":").Select(int.Parse).ToArray();
            list.Add(time[0] * 60 + time[1]);
        }

        list.Sort();

        list.Add(list[0] + 1440);

        int minDifference = int.MaxValue;
        for (int i = 1; i < list.Count; i++) {
            minDifference = Math.Min(minDifference, list[i] - list[i - 1]);
        }

        return minDifference;
    }
}
