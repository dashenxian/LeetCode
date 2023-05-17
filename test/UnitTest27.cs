using Namespace27;

namespace LeetCodeTest
{
    public class UnitTest27
    {
        [Fact]
        public void Test1()
        {
            var input = new[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            var sl = new Solution();
            sl.RemoveElement(input, 2).ShouldBe(5);
            input.Take(5).ShouldContain(0);
            input.Take(5).ShouldContain(1);
            input.Take(5).ShouldContain(3);
            input.Take(5).ShouldContain(4);
        }
        [Fact]
        public void Test2()
        {
            var input = new[] { 3,2,2,3 };
            var sl = new Solution();
            sl.RemoveElement(input, 3).ShouldBe(2);
            input.Take(2).ShouldContain(2);
        }
    }
}