public class Solution {
    public string RemoveStars(string s) {
        Stack<char> stack = new Stack<char>();
        for(int i=0;i<s.Length;i++){
            if(s[i]=='*'){
                stack.Pop();
            }
            else {
                stack.Push(s[i]);
            }
        }
        char[] reversed = stack.ToArray();
        Array.Reverse(reversed); 
        return new string(reversed);    }
}