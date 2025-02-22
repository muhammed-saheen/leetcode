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
public class FindElements {

    public FindElements(TreeNode root) {
       if (root==null){
        return;
       } 
       construct_tree(root,0);

    }
    HashSet<int> set =new HashSet<int>();
    public void construct_tree(TreeNode root,int val){
     root.val=val;
     set.Add(val);

     if(root.left!=null){
      construct_tree(root.left,val*2+1);
     }
    if(root.right!=null){
      construct_tree(root.right,val*2+2);
     }
    }
    
    public bool Find(int target) {
        return set.Contains(target);
    }
}

/**
 * Your FindElements object will be instantiated and called as such:
 * FindElements obj = new FindElements(root);
 * bool param_1 = obj.Find(target);
 */