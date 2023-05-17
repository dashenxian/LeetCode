namespace LeetCode.Common;

/// <summary>
/// 查并集
/// </summary>
public class UnionFind
{
    /// <summary>
    /// 集合父节点或根节点
    /// </summary>
    private List<int> Parent { get; set; }
    /// <summary>
    /// 集合深度
    /// </summary>
    private List<int> Rank { get; set; }
    public UnionFind(int count)
    {
        Parent = new List<int>(count);
        Rank = new List<int>(count);
        for (int i = 0; i < count; i++)
        {
            Parent.Add(i);
            Rank.Add(1);
        }
    }
    /// <summary>
    /// 查询集合
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public int Find(int x)
    {
        if (Parent[x] == x)
        {
            return x;
        }
        return Parent[x] = Find(Parent[x]);
    }
    /// <summary>
    /// 合并集合
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public void Union(int x, int y)
    {
        int fx = Find(x);
        int fy = Find(y);
        if (fx == fy) { return; }
        if (Rank[fx] < Rank[fy]) { Parent[fy] = fx; }
        else
        {
            if (Rank[fx] == Rank[fy]) { Rank[fy]++; }
            Parent[fx] = fy;
        }
    }
    /// <summary>
    /// 是否在一个集合
    /// </summary>
    /// <param name="x">要查询的节点</param>
    /// <param name="y">要查询的节点</param>
    /// <returns></returns>
    public bool IsSame(int x, int y)
    {
        return Find(x) == Find(y);
    }
    /// <summary>
    /// 查询是否在一个集合，如果在一个集合返回false，如果不在一个集合则合并到一个集合并返回true
    /// </summary>
    /// <param name="x">要查询的节点</param>
    /// <param name="y">要查询的节点</param>
    /// <returns></returns>
    public bool FindAndUnion(int x, int y)
    {
        if (!IsSame(x,y))
        {
            Union(x, y); return true;
        }
        return false;
    }
    public override string ToString()
    {
        return string.Join(',', Parent);
    }
}
