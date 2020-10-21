/*
 * @lc app=leetcode.cn id=46 lang=csharp
 *
 * [46] 全排列
 *
 * https://leetcode-cn.com/problems/permutations/description/
 *
 * algorithms
 * Medium (76.63%)
 * Likes:    856
 * Dislikes: 0
 * Total Accepted:    177.9K
 * Total Submissions: 231.9K
 * Testcase Example:  '[1,2,3]'
 *
 * 给定一个 没有重复 数字的序列，返回其所有可能的全排列。
 * 
 * 示例:
 * 
 * 输入: [1,2,3]
 * 输出:
 * [
 * ⁠ [1,2,3],
 * ⁠ [1,3,2],
 * ⁠ [2,1,3],
 * ⁠ [2,3,1],
 * ⁠ [3,1,2],
 * ⁠ [3,2,1]
 * ]
 * 
 */

// @lc code=start
public class Solution {
   private IList<IList<int>> res = new List<IList<int>>();
            public IList<IList<int>> Permute(int[] nums)
            {
                backtrack(nums, new List<int>());
                return res;
            }
            private void backtrack(int[] nums, IList<int> list)
            {
                if (nums.Length == list.Count())
                {
                    res.Add(new List<int>(list));
                }
                for (int i = 0; i < nums.Length; i++)
                {
                    if (list.Contains(nums[i]))
                    {
                        continue;
                    }
                    list.Add(nums[i]);
                    backtrack(nums, list);
                    list.RemoveAt(list.Count - 1);
                }
            }
}
// @lc code=end

