/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

// @lc code=start
public class Solution
{
    /*
给定一个整数数组 nums 和一个整数目标值 target，请你在该数组中找出 和为目标值 target  的那 两个 整数，并返回它们的数组下标。
你可以假设每种输入只会对应一个答案。但是，数组中同一个元素在答案里不能重复出现。
你可以按任意顺序返回答案。
*/
    public int[] TwoSum(int[] nums, int target)
    {
        var dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var num = target - nums[i];
            if (dic.ContainsKey(num))
            {
                return new[] { dic[num], i };
            }
            dic[nums[i]]= i;
        }

        throw new ArgumentException("没有符合条件的数据");
    }
}
// @lc code=end

