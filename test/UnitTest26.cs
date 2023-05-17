using Namespace26;

namespace LeetCodeTest
{
    public class UnitTest26
    {
        [Fact]
        public void Test1()
        {
            var input = new[] { 1, 1, 2 };
            var sl = new Solution();
            sl.RemoveDuplicates(input).ShouldBe(2);
            input.Take(2).ShouldBe(new[] { 1, 2 });
        }
        [Fact]
        public void Test2()
        {
            var input = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var sl = new Solution();
            sl.RemoveDuplicates(input).ShouldBe(5);
            input.Take(5).ShouldBe(new[] { 0, 1, 2, 3, 4 });
        }

    }
}