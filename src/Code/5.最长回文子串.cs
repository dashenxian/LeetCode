/*
 * @lc app=leetcode.cn id=5 lang=csharp
 *
 * [5] 最长回文子串
 *
 * https://leetcode-cn.com/problems/longest-palindromic-substring/description/
 *
 * algorithms
 * Medium (31.12%)
 * Likes:    2449
 * Dislikes: 0
 * Total Accepted:    321.1K
 * Total Submissions: 1M
 * Testcase Example:  '"babad"'
 *
 * 给定一个字符串 s，找到 s 中最长的回文子串。你可以假设 s 的最大长度为 1000。
 * 
 * 示例 1：
 * 
 * 输入: "babad"
 * 输出: "bab"
 * 注意: "aba" 也是一个有效答案。
 * 
 * 
 * 示例 2：
 * 
 * 输入: "cbbd"
 * 输出: "bb"
 * 
 * 
 */

// @lc code=start
using System;
public class Solution
{

    public string LongestPalindrome(string s)
    {
        var maxLength = 0;
        var maxStr = "";
        for (int i = 0; i < s.Length; i++)
        {
            var curMaxLength = 1;
            while (i - curMaxLength >= 0 && i + curMaxLength < s.Length)
            {
                if (s[i - curMaxLength] != s[i + curMaxLength])
                {
                    break;
                }
                curMaxLength++;
            }
            curMaxLength--;
            if (maxLength < (curMaxLength * 2 + 1))
            {
                maxLength = (curMaxLength * 2 + 1);
                maxStr = s.Substring(i - curMaxLength , curMaxLength * 2 + 1);
            }
            curMaxLength = 0;
            while (i - curMaxLength >= 0 && i + curMaxLength + 1 < s.Length)
            {
                if (s[i - curMaxLength] != s[i + curMaxLength + 1])
                {
                    break;
                }
                curMaxLength++;
            }
            curMaxLength--;
            if (maxLength < (curMaxLength + 1) * 2)
            {
                maxLength = (curMaxLength + 1) * 2;
                maxStr = s.Substring(i - curMaxLength, (curMaxLength + 1) * 2);
            }
        }
        return maxStr;
    }

    // public string LongestPalindrome(string s)
    // {
    //     var maxLength = 0;
    //     var maxString = "";
    //     for (int i = 0; i < s.Length; i++)
    //     {
    //         if (maxLength > s.Length - i)
    //         {
    //             break;
    //         }
    //         for (int j = s.Length; j > i; j--)
    //         {
    //             if (maxLength > j - i)
    //             {
    //                 break;
    //             }
    //             if (IsHuiWen(s.Substring(i, j - i)) && j - i > maxLength)
    //             {
    //                 maxLength = j - i;
    //                 maxString = s.Substring(i, j - i);
    //             }
    //         }
    //     }
    //     return maxString;
    // }
    public bool IsHuiWen(string s)
    {
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (s[i] != s[s.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}
// @lc code=end

