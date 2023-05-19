/*
 * @lc app=leetcode.cn id=118 lang=csharp
 *
 * [118] 杨辉三角
 */
namespace Namespace118;
// @lc code=start
public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        var result = new List<IList<int>>();
        for (int i = 0; i < numRows; i++)
        {
            if (i == 0)
            {
                result.Add(new List<int> { 1 });
                continue;
            }

            var list = new List<int>(i + 1);
            for (int j = 0; j < i + 1; j++)
            {
                if (j == 0 || j >= result[i - 1].Count)
                {
                    list.Add(1);
                    continue;
                }
                list.Add(result[i - 1][j - 1] + result[i - 1][j]);
            }
            result.Add(list);
        }

        return result;
    }
}
// @lc code=end

