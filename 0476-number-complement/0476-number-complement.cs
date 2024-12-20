public class Solution {
    public int FindComplement(int num) {
       string str = Convert.ToString(num, 2);
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < str.Length; i++) {
            if (str[i] == '0') {
                result.Append('1'); 
            } else {
                result.Append('0');
            }
        }
        return Convert.ToInt32(result.ToString(), 2);
    }
}