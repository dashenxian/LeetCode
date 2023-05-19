using Namespace11;
using Shouldly;

namespace LeetCodeTest
{
    public class UnitTest11
    {
        [Fact]
        public void Test1()
        {
            var sl = new Solution();
            sl.Min(4,2,3).ShouldBe(2);
            sl.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }).ShouldBe(49);
            sl.MaxArea(new int[] { 1, 1}).ShouldBe(1);
        }

    }
}