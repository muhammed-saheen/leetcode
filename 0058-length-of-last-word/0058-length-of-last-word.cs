public class Solution {
    public int LengthOfLastWord(string s) {
        string[] arr = s.Trim().Split( ' ', StringSplitOptions.RemoveEmptyEntries);
      return arr[arr.Length-1].Length;
    }
}