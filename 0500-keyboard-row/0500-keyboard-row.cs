public class Solution {
    public string[] FindWords(string[] words) {
       string[] arr = { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
       List<String> newls = new List<String>(); 
       for(int i=0;i<words.Length;i++){
        var valid =false ;
        for (int j=0;j<arr.Length;j++){
          var wrd=words[i].ToLower();
            if (wrd.All(c => arr[j].Contains(c))) {
            newls.Add(words[i]);
            valid =true;
            break;
          }
          if(valid){
            break;
          }
        } 
       } 
       return newls.ToArray() ;
    }
}