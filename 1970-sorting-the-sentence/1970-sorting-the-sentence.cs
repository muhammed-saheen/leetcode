public class Solution {
    public string SortSentence(string s) {
        string[] arr = s.Split(" ");
        string[] newarr = new string[arr.Length];
        
        for (int i = 0; i < arr.Length; i++) {
            string word = arr[i];
            int position = word[word.Length - 1] - '0'; 
            newarr[position - 1] = word.Substring(0, word.Length - 1); 
        }
        
        return string.Join(" ", newarr);
    }
}
