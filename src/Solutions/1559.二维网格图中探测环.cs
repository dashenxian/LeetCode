/*
 * @lc app=leetcode.cn id=1559 lang=csharp
 *
 * [1559] 二维网格图中探测环
 */
namespace Namespace1159;

// @lc code=start

#region 原方法
public partial class Solution
{
    public bool ContainsCycle(char[][] grid)
    {
        int n = grid.Length;
        int m = grid[0].Length;
        UnionFind uf = new UnionFind(n * m);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i > 0 && grid[i][j] == grid[i - 1][j])
                {
                    if (!uf.FindAndUnion(i * m + j, (i - 1) * m + j))
                    {
                        return true;
                    }
                }

                if (j > 0 && grid[i][j] == grid[i][j - 1])
                {
                    if (!uf.FindAndUnion(i * m + j, i * m + j - 1))
                    {
                        return true;
                    }
                }
            }
        }
        return false;

    }
}
#endregion
#region 官方答案
//public class Solution
//{
//    public bool ContainsCycle(char[][] grid)
//    {
//        int m = grid.Length;
//        int n = grid[0].Length;
//        UnionFind uf = new UnionFind(m * n);
//        for (int i = 0; i < m; ++i)
//        {
//            for (int j = 0; j < n; ++j)
//            {
//                if (i > 0 && grid[i][j] == grid[i - 1][j])
//                {
//                    if (!uf.findAndUnite(i * n + j, (i - 1) * n + j))
//                    {
//                        return true;
//                    }
//                }
//                if (j > 0 && grid[i][j] == grid[i][j - 1])
//                {
//                    if (!uf.findAndUnite(i * n + j, i * n + j - 1))
//                    {
//                        return true;
//                    }
//                }
//            }
//        }
//        return false;
//    }
//    class UnionFind
//    {
//        int[] parent;
//        int[] size;


//        public UnionFind(int n)
//        {
//            parent = new int[n];
//            for (int i = 0; i < n; ++i)
//            {
//                parent[i] = i;
//            }
//            size = new int[n];
//            Array.Fill(size, 1);

//        }

//        public int findset(int x)
//        {
//            return parent[x] == x ? x : (parent[x] = findset(parent[x]));
//        }

//        public void unite(int x, int y)
//        {
//            if (size[x] < size[y])
//            {
//                int temp = x;
//                x = y;
//                y = temp;
//            }
//            parent[y] = x;
//            size[x] += size[y];
//        }

//        public bool findAndUnite(int x, int y)
//        {
//            int parentX = findset(x);
//            int parentY = findset(y);
//            if (parentX != parentY)
//            {
//                unite(parentX, parentY);
//                return true;
//            }
//            return false;
//        }
//    }
//}

#endregion
// @lc code=end

