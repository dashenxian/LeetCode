/*
 * @lc app=leetcode.cn id=509 lang=csharp
 *
 * [509] 斐波那契数
 *
 * https://leetcode-cn.com/problems/fibonacci-number/description/
 *
 * algorithms
 * Easy (66.40%)
 * Likes:    149
 * Dislikes: 0
 * Total Accepted:    72.7K
 * Total Submissions: 109.5K
 * Testcase Example:  '2'
 *
 * 斐波那契数，通常用 F(n) 表示，形成的序列称为斐波那契数列。该数列由 0 和 1 开始，后面的每一项数字都是前面两项数字的和。也就是：
 * 
 * F(0) = 0,   F(1) = 1
 * F(N) = F(N - 1) + F(N - 2), 其中 N > 1.
 * 
 * 
 * 给定 N，计算 F(N)。
 * 
 * 
 * 
 * 示例 1：
 * 
 * 输入：2
 * 输出：1
 * 解释：F(2) = F(1) + F(0) = 1 + 0 = 1.
 * 
 * 
 * 示例 2：
 * 
 * 输入：3
 * 输出：2
 * 解释：F(3) = F(2) + F(1) = 1 + 1 = 2.
 * 
 * 
 * 示例 3：
 * 
 * 输入：4
 * 输出：3
 * 解释：F(4) = F(3) + F(2) = 2 + 1 = 3.
 * 
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * 0 ≤ N ≤ 30
 * 
 * 
 */
namespace Namespace509;
// @lc code=start
public class Solution
{
    public int Fib1(int N)
    {
        if (N < 1)
        {
            return 0;
        }

        if (N < 3)
        {
            return 1;
        }

        var pre = 1;
        var cur = 1;
        for (int i = 3; i <= N; i++)
        {
            var sum = pre + cur;
            pre = cur;
            cur = sum;
        }

        return cur;
    }
    public int Fib4(int N)
    {
        if (N < 1)
        {
            return 0;
        }
        if (N < 3)
        {
            return 1;
        }
        var dic = new int[N + 1];
        dic[1] = 1;
        dic[2] = 1;
        for (int i = 3; i <= N; i++)
        {
            dic[i] = dic[i - 1] + dic[i - 2];
        }

        return dic[N];
    }
    // public int Fib2(int N)
    // {
    //     if (N < 1)
    //     {
    //         return 0;
    //     }
    //     var map = new int[N + 1];
    //     return DicFib(map, N);
    // }

    // private int DicFib(int[] map, int n)
    // {
    //     if (n < 3)
    //     {
    //         return 1;
    //     }

    //     if (map[n] != 0)
    //     {
    //         return map[n];
    //     }

    //     map[n] = DicFib(map, n - 1) + DicFib(map, n - 2);
    //     return map[n];
    // }
    // public int Fib3(int N)
    // {
    //     if (N <= 0)
    //     {
    //         return 0;
    //     }
    //     if (N < 3)
    //     {
    //         return 1;
    //     }
    //     return Fib(N - 1) + Fib(N - 2);
    // }
}
// @lc code=end

