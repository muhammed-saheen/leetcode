using System;
using System.Collections.Generic;

public class Solution {
    public string RemoveOccurrences(string s, string part) {
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++) {
            stack.Push(s[i]);

            if (stack.Count >= part.Length) {
                char[] arr = new char[part.Length];
                int k = part.Length - 1;
                foreach (char ch in stack) {
                    if (k < 0) break;
                    arr[k--] = ch;
                }

                if (new string(arr) == part) {
                    for (int j = 0; j < part.Length; j++) {
                        stack.Pop();
                    }
                }
            }
        }

        char[] resultArray = stack.ToArray();
        Array.Reverse(resultArray); 
        return new string(resultArray);
    }
}
