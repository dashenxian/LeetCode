/*
 * @lc app=leetcode.cn id=171 lang=csharp
 *
 * [171] Excel 表列序号
 */

namespace Namespace171;
// @lc code=start
public class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        var dic = new Dictionary<char, int>()
        {
            { 'A', 1 },
            { 'B', 2 },
            { 'C', 3 },
            { 'D', 4 },
            { 'E', 5 },
            { 'F', 6 },
            { 'G', 7 },
            { 'H', 8 },
            { 'I', 9 },
            { 'J', 10 },
            { 'K', 11 },
            { 'L', 12 },
            { 'M', 13 },
            { 'N', 14 },
            { 'O', 15 },
            { 'P', 16 },
            { 'Q', 17 },
            { 'R', 18 },
            { 'S', 19 },
            { 'T', 20 },
            { 'U', 21 },
            { 'V', 22 },
            { 'W', 23 },
            { 'X', 24 },
            { 'Y', 25 },
            { 'Z', 26 }
        };
        var result = 0;
        for (int i = 0; i < columnTitle.Length; i++)
        {
            result += dic[columnTitle[i]] * Pow(26, columnTitle.Length - i - 1);
        }

        return result;
    }

    private int Pow(int x, int y)
    {
        int result = 1;
        for (int i = 0; i < y; i++)
        {
            result *= x;
        }
        return result;
    }
}
// @lc code=end

