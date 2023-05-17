/*
 * @lc app=leetcode.cn id=27 lang=csharp
 *
 * [27] 移除元素
 */

namespace Namespace27;
// @lc code=start
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var count = nums.Length;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (nums[i] == val)
            {
                //for (int j = 0; j < count - i - 1; j++)
                //{
                //    nums[i + j] = nums[i + j + 1];
                //}
                count--;
                nums[i] = nums[count];
            }
        }

        return count;
    }
}
// @lc code=end

