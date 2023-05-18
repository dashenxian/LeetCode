/*
 * @lc app=leetcode.cn id=168 lang=csharp
 *
 * [168] Excel表列名称
 */

using System.Text;

namespace Namespace168;
// @lc code=start
public class Solution
{
    public string ConvertToTitle(int columnNumber)
    {
        const int baseNumber = 26;
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        StringBuilder result = new StringBuilder();

        while (columnNumber > 0)
        {
            int remainder = (columnNumber - 1) % baseNumber;
            result.Insert(0, chars[remainder]);
            columnNumber = (columnNumber - remainder - 1) / baseNumber;
        }

        return result.ToString();
    }
}
// @lc code=end

