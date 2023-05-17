namespace LeetCode.Common;

public class UnionFind
{
    private List<int> Parent { get; set; }
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

    public int Find(int x)
    {
        if (Parent[x] == x)
        {
            return x;
        }
        return Parent[x] = Find(Parent[x]);
    }
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
    public bool IsSame(int x, int y)
    {
        return Find(x) == Find(y);
    }

    public bool FindAndUnion(int x, int y)
    {
        int fx = Find(x);
        int fy = Find(y);
        if (fx != fy)
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
