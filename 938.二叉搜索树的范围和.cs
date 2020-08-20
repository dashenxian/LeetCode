/*
 * @lc app=leetcode.cn id=938 lang=csharp
 *
 * [938] 二叉搜索树的范围和
 *
 * https://leetcode-cn.com/problems/range-sum-of-bst/description/
 *
 * algorithms
 * Easy (77.00%)
 * Likes:    127
 * Dislikes: 0
 * Total Accepted:    29.9K
 * Total Submissions: 38.8K
 * Testcase Example:  '[10,5,15,3,7,null,18]\n7\n15'
 *
 * 给定二叉搜索树的根结点 root，返回 L 和 R（含）之间的所有结点的值的和。
 * 
 * 二叉搜索树保证具有唯一的值。
 * 
 * 
 * 
 * 示例 1：
 * 
 * 输入：root = [10,5,15,3,7,null,18], L = 7, R = 15
 * 输出：32
 * 
 * 
 * 示例 2：
 * 
 * 输入：root = [10,5,15,3,7,13,18,1,null,6], L = 6, R = 10
 * 输出：23
 * 
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * 树中的结点数量最多为 10000 个。
 * 最终的答案保证小于 2^31。
 * 
 * 
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public int RangeSumBST(TreeNode root, int L, int R)
    {
        if (root == null)
        {
            return 0;
        }

        var val = 0;
        if (L <= root.val && root.val <= R)
        {
            return val = root.val;
        }

        return val + RangeSumBST(root.left, L, R) + RangeSumBST(root.right, L, R);
    }
}
// @lc code=end

