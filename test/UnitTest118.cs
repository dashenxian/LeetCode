using Namespace118;

namespace LeetCodeTest
{
    public class UnitTest118
    {
        [Fact]
        public void Test1()
        {
            var sl = new Solution();
            sl.Generate(5).ShouldBe(
                new IList<int>[]
                {
                    new List<int> { 1 },
                    new List<int> { 1, 1 },
                    new List<int> { 1, 2, 1 },
                    new List<int> { 1, 3, 3, 1 },
                    new List<int> { 1, 4, 6, 4, 1 }
                });
            sl.Generate(1).ShouldBe(new IList<int>[] { new List<int> { 1 } });
        }

    }
}