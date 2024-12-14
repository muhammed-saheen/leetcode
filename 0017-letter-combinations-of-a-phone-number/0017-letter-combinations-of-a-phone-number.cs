public class Solution {
    public IList<string> LetterCombinations(string digits) {
        string [] symbols ={"_","_","abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"};
        List<string> ls =new List<string>{};
        List<string> result =new List<string>();
      
        foreach (char i in digits) {
        int index = i - '0'; 
        ls.Add(symbols[index]);
        };
        if(ls.Count==0){
            return [];
        }
         void GenerateCombinations(string current, int depth) {
            if (depth == ls.Count) {
                result.Add(current);
                return;
            }

            foreach (char c in ls[depth]) {
                GenerateCombinations(current + c, depth + 1);
            }
        }

        GenerateCombinations("", 0);

      return result ;

    }
}