public class Solution {
    public string ReverseVowels(string s) {
        StringBuilder result = new StringBuilder();
        List<char> vowels = new List<char>();
        for (int i = 0; i < s.Length; i++) {
            if ("aeiouAEIOU".Contains(s[i])) {
                vowels.Add(s[i]);
            }
        }
        int Index = vowels.Count-1;
        for (int i = 0; i < s.Length; i++) {
            if ("aeiouAEIOU".Contains(s[i])) {
                result.Append(vowels[Index]);
                Index--;
            } else {
                result.Append(s[i]); 
            }
        }

        return result.ToString();
    }
}
