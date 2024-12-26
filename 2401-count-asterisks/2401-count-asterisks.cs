public class Solution {
    public int CountAsterisks(string s) {
        int count = 0;
        bool insidePair = false;
        
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '|') {
                insidePair = !insidePair; 
            } else if (s[i] == '*' && !insidePair) {
                count++; 
            }
        }
        
        return count;
    }
}
