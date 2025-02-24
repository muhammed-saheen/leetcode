/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
          List<int> ls = new List<int>();
          RecursionMethod(ls,root);
          return ls;
    }
    public void RecursionMethod (List<int> list,TreeNode root){
        if(root==null) return ;
        if(root.left!=null){
            RecursionMethod(list,root.left);
        }
        list.Add(root.val);
        if(root.right!=null){
            RecursionMethod(list,root.right);
        }
    }
}