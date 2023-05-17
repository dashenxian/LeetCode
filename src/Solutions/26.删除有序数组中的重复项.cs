/*
 * @lc app=leetcode.cn id=26 lang=csharp
 *
 * [26] 删除有序数组中的重复项
 */

namespace Namespace26;
// @lc code=start
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        #region 官方
        int j = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == nums[j])
            {
                continue;
            }
            j++;
            nums[j] = nums[i];
        }

        return j + 1;
        #endregion
        //var hash = new Dictionary<int, int>();
        //var length = nums.Length;
        //for (int i = 0; i < length; i++)
        //{
        //    if (!hash.ContainsKey(nums[i]))
        //    {
        //        hash[nums[i]] = i;
        //    }
        //    else
        //    {
        //        for (int j = i; j < length - 1; j++)
        //        {
        //            nums[j] = nums[j + 1];
        //        }

        //        i--;
        //        length--;
        //    }
        //}

        //return length;
    }
}
// @lc code=end

