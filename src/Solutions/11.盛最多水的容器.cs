/*
 * @lc app=leetcode.cn id=11 lang=csharp
 *
 * [11] 盛最多水的容器
 */
namespace Namespace11;
// @lc code=start
public class Solution
{
    public int MaxArea(int[] height)
    {
        var max = 0;
        //双指针法，从两边向中间移动，每次移动较小的那个指针
        var left = 0;
        var right = height.Length - 1;
        while (left < right)
        {
            var curArea = (right - left) * Min(height[left], height[right]);
            if (max < curArea)
            {
                max = curArea;
            }

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        #region 暴力法
        //// 暴力法，穷举所有装水情况，记录最大值
        //for (int i = 0; i < height.Length; i++)
        //{
        //    for (int j = height.Length - 1; j >= i; j--)
        //    {
        //        if (j < height.Length - 1 && height[j] < height[j + 1])
        //        {
        //            continue;
        //        }
        //        var curArea = (j - i) * Min(height[i], height[j]);
        //        if (max < curArea)
        //        {
        //            max = curArea;
        //        }
        //    }
        //} 
        #endregion
        return max;
    }

    public int Min(params int[] nums)
    {
        var min = int.MaxValue;
        foreach (var num in nums)
        {
            if (num < min)
            {
                min = num;
            }
        }
        return min;
    }
}
// @lc code=end

