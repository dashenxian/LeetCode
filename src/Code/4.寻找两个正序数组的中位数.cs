/*
 * @lc app=leetcode.cn id=4 lang=csharp
 *
 * [4] 寻找两个正序数组的中位数
 *
 * https://leetcode.cn/problems/median-of-two-sorted-arrays/description/
 *
 * algorithms
 * Hard (41.58%)
 * Likes:    5828
 * Dislikes: 0
 * Total Accepted:    802.6K
 * Total Submissions: 1.9M
 * Testcase Example:  '[1,3]\n[2]'
 *
 * 给定两个大小分别为 m 和 n 的正序（从小到大）数组 nums1 和 nums2。请你找出并返回这两个正序数组的 中位数 。
 * 
 * 算法的时间复杂度应该为 O(log (m+n)) 。
 * 
 * 
 * 
 * 示例 1：
 * 
 * 
 * 输入：nums1 = [1,3], nums2 = [2]
 * 输出：2.00000
 * 解释：合并数组 = [1,2,3] ，中位数 2
 * 
 * 
 * 示例 2：
 * 
 * 
 * 输入：nums1 = [1,2], nums2 = [3,4]
 * 输出：2.50000
 * 解释：合并数组 = [1,2,3,4] ，中位数 (2 + 3) / 2 = 2.5
 * 
 * 
 * 
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * nums1.length == m
 * nums2.length == n
 * 0 <= m <= 1000
 * 0 <= n <= 1000
 * 1 <= m + n <= 2000
 * -10^6 <= nums1[i], nums2[i] <= 10^6
 * 
 * 
 */
namespace Namespace4;
// @lc code=start

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var totalLength = nums1.Length + nums2.Length;
        var startCount = totalLength / 2;
        var endCount = startCount;
        var forCount = 0;
        if (totalLength % 2 == 0)
        {
            endCount = startCount + 1;
        }
        else
        {
            startCount = startCount + 1;
            endCount = startCount;
        }
        var result = 0d;
        var nums1Index = 0;
        var nums2Index = 0;
        for (int i = 0; i < endCount; i++)
        {
            var current = 0d;
            var curNum1 = nums1Index >= nums1.Length ? double.MaxValue : nums1[nums1Index];
            var curNum2 = nums2Index >= nums2.Length ? double.MaxValue : nums2[nums2Index];

            if (curNum1 < curNum2)
            {
                current = curNum1;
                nums1Index++;
            }
            else
            {
                current = curNum2;
                nums2Index++;
            }

            if (i >= startCount - 1)
            {
                result += current;
            }
        }
        result = result / (endCount - startCount + 1);
        return result;
    }
    public double FindMedianSortedArrays_answer(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
        {
            return FindMedianSortedArrays(nums2, nums1);
        }

        int m = nums1.Length;
        int n = nums2.Length;
        int left = 0, right = m;
        // median1：前一部分的最大值
        // median2：后一部分的最小值
        int median1 = 0, median2 = 0;

        while (left <= right)
        {
            // 前一部分包含 nums1[0 .. i-1] 和 nums2[0 .. j-1]
            // 后一部分包含 nums1[i .. m-1] 和 nums2[j .. n-1]
            int i = (left + right) / 2;
            int j = (m + n + 1) / 2 - i;

            // nums_im1, nums_i, nums_jm1, nums_j 分别表示 nums1[i-1], nums1[i], nums2[j-1], nums2[j]
            int nums_im1 = (i == 0 ? int.MinValue : nums1[i - 1]);
            int nums_i = (i == m ? int.MaxValue : nums1[i]);
            int nums_jm1 = (j == 0 ? int.MinValue : nums2[j - 1]);
            int nums_j = (j == n ? int.MaxValue : nums2[j]);

            if (nums_im1 <= nums_j)
            {
                median1 =nums_im1>nums_jm1?nums_im1:nums_jm1; 
                median2 =nums_i<nums_j?nums_i:nums_j;
                left = i + 1;
            }
            else
            {
                right = i - 1;
            }
        }

        return (m + n) % 2 == 0 ? (median1 + median2) / 2.0 : median1;
    }
}


// @lc code=end

