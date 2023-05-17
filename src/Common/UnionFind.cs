namespace LeetCode.Common;

/// <summary>
/// �鲢��
/// </summary>
public class UnionFind
{
    /// <summary>
    /// ���ϸ��ڵ����ڵ�
    /// </summary>
    private List<int> Parent { get; set; }
    /// <summary>
    /// �������
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
    /// ��ѯ����
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
    /// �ϲ�����
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
    /// �Ƿ���һ������
    /// </summary>
    /// <param name="x">Ҫ��ѯ�Ľڵ�</param>
    /// <param name="y">Ҫ��ѯ�Ľڵ�</param>
    /// <returns></returns>
    public bool IsSame(int x, int y)
    {
        return Find(x) == Find(y);
    }
    /// <summary>
    /// ��ѯ�Ƿ���һ�����ϣ������һ�����Ϸ���false���������һ��������ϲ���һ�����ϲ�����true
    /// </summary>
    /// <param name="x">Ҫ��ѯ�Ľڵ�</param>
    /// <param name="y">Ҫ��ѯ�Ľڵ�</param>
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
