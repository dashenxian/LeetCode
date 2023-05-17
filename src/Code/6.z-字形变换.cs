/*
 * @lc app=leetcode.cn id=6 lang=csharp
 *
 * [6] Z 字形变换
 *
 * https://leetcode-cn.com/problems/zigzag-conversion/description/
 *
 * algorithms
 * Medium (48.33%)
 * Likes:    760
 * Dislikes: 0
 * Total Accepted:    151.8K
 * Total Submissions: 313.8K
 * Testcase Example:  '"PAYPALISHIRING"\n3'
 *
 * 将一个给定字符串根据给定的行数，以从上往下、从左到右进行 Z 字形排列。
 * 
 * 比如输入字符串为 "LEETCODEISHIRING" 行数为 3 时，排列如下：
 * 
 * L   C   I   R
 * E T O E S I I G
 * E   D   H   N
 * 
 * 
 * 之后，你的输出需要从左往右逐行读取，产生出一个新的字符串，比如："LCIRETOESIIGEDHN"。
 * 
 * 请你实现这个将字符串进行指定行数变换的函数：
 * 
 * string convert(string s, int numRows);
 * 
 * 示例 1:
 * 
 * 输入: s = "LEETCODEISHIRING", numRows = 3
 * 输出: "LCIRETOESIIGEDHN"
 * 
 * 
 * 示例 2:
 * 
 * 输入: s = "LEETCODEISHIRING", numRows = 4
 * 输出: "LDREOEIIECIHNTSG"
 * 解释:
 * 
 * L     D     R
 * E   O E   I I
 * E C   I H   N
 * T     S     G
 * 
 */
namespace Namespace6z;
// @lc code=start
public class Solution
{
    public string Convert(string s, int numRows)
    {
        var list = new List<List<char>>();
        for (int i = 0; i < numRows; i++)
        {
            list.Add(new List<char>());
        }

        var rowIndex = 0;
        var step = 1;
        foreach (var c in s)
        {
            if (rowIndex <= 0)
            {
                rowIndex = 0;
                step = 1;
            }
            else if (rowIndex >= numRows - 1)
            {
                rowIndex = numRows - 1;
                step = -1;
            }
            list[rowIndex].Add(c);

            rowIndex += step;
        }
        var str = "";
        foreach (var ls in list)
        {
            foreach (var c in ls)
            {
                str += c;
            }
        }
        return str;
    }
}
// @lc code=end

