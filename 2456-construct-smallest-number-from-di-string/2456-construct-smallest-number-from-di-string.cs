public class Solution {
    public string SmallestNumber(string pattern) {
        StringBuilder s = new StringBuilder();
        Stack<int> stk = new Stack<int>();  

        for (int i = 0; i <= pattern.Length; i++) {
            stk.Push(i + 1); 
            
            if (i == pattern.Length || pattern[i] == 'I') {
                while (stk.Count > 0) {
                    s.Append(stk.Pop());  
                }
            }
        }
        
        return s.ToString();
    }
}
