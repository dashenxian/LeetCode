/*
 * @lc app=leetcode.cn id=3 lang=csharp
 *
 * [3] 无重复字符的最长子串
 *
 * https://leetcode-cn.com/problems/longest-substring-without-repeating-characters/description/
 *
 * algorithms
 * Medium (35.13%)
 * Likes:    4002
 * Dislikes: 0
 * Total Accepted:    575K
 * Total Submissions: 1.6M
 * Testcase Example:  '"abcabcbb"'
 *
 * 给定一个字符串，请你找出其中不含有重复字符的 最长子串 的长度。
 * 
 * 示例 1:
 * 
 * 输入: "abcabcbb"
 * 输出: 3 
 * 解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。
 * 
 * 
 * 示例 2:
 * 
 * 输入: "bbbbb"
 * 输出: 1
 * 解释: 因为无重复字符的最长子串是 "b"，所以其长度为 1。
 * 
 * 
 * 示例 3:
 * 
 * 输入: "pwwkew"
 * 输出: 3
 * 解释: 因为无重复字符的最长子串是 "wke"，所以其长度为 3。
 * 请注意，你的答案必须是 子串 的长度，"pwke" 是一个子序列，不是子串。
 * 
 * 
 */

// @lc code=start
public class Solution
{
    // public int LengthOfLongestSubstring(string s)
    // {
    //     List<char> ls = new List<char>();
    //     int n = s.Length;
    //     int intMaxLength = 0;
    //     for (int i = 0; i < n; i++)
    //     {
    //         if (ls.Contains(s[i]))
    //         {
    //             ls.RemoveRange(0, ls.IndexOf(s[i]) + 1);
    //         }
    //         ls.Add(s[i]);
    //         intMaxLength = ls.Count > intMaxLength ? ls.Count : intMaxLength;
    //     }
    //     return intMaxLength;
    // }

    // public int LengthOfLongestSubstring(string s)
    // {
    //     if (string.IsNullOrEmpty(s))
    //     {
    //         return 0;
    //     }
    //     int max = 1;
    //     Queue<char> que = new Queue<char>();
    //     foreach (var c in s)
    //     {
    //         while (que.Contains(c))
    //         {
    //             que.Dequeue();
    //         }
    //         que.Enqueue(c);
    //         max = que.Count > max ? que.Count : max;
    //     }

    //     return max;
    // }

    public int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }
        var max = 1;
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 1; j < s.Length - i; j++)
            {
                if (s.Substring(i, j).IndexOf(s[i + j]) > -1)
                {
                    if (j > max)
                    {
                        max = j;
                    }
                    break;
                }
                else
                {
                    if (j + 1 > max)
                    {
                        max = j + 1;
                    }
                }
            }
        }
        return max;
    }

}
// @lc code=end

