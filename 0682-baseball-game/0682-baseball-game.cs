public class Solution {
    public int CalPoints(string[] operations) {
        List<int> scores = new List<int>(); 
        
        foreach (var operation in operations) {
            if (int.TryParse(operation, out int num)) {
                scores.Add(num);
            } 
            else if (operation == "+") {
                int last = scores[scores.Count - 1];
                int secondLast = scores[scores.Count - 2];
                scores.Add(last + secondLast);
            } 
            else if (operation == "D") {
                int last = scores[scores.Count - 1];
                scores.Add(2 * last);
            } 
            else if (operation == "C") {
                scores.RemoveAt(scores.Count - 1);
            }
        }
        
        return scores.Sum();
    }
}
