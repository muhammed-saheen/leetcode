public class Solution {
    public int MaxDepth(TreeNode root) {
        if (root == null) {
            return 0; // Base case: if the node is null, depth is 0
        }

        int leftDepth = MaxDepth(root.left);
        int rightDepth = MaxDepth(root.right);

        return Math.Max(leftDepth, rightDepth) + 1;
    }
}
