public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        int count =0;
        for(int i=0;i<items.Count;i++){
            if(ruleKey=="type"){
              if(ruleValue==items[i][0]){
                count++;
              }
            }else if(ruleKey=="color"){
              if(ruleValue==items[i][1]){
                count++;
              }
            }else {
              if(ruleValue==items[i][2]){
                count++;
              }
            }
        }
        return count ;
    }
}