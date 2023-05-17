using Shouldly;
using Namespace1159;

namespace LeetCodeTest
{
    public class UnitTest1559
    {
        [Fact]
        public void Test1()
        {
            char[][] input = new char[][]
            {
                new []{ 'a', 'a', 'a', 'a' },
                new []{ 'a', 'b', 'b', 'a' },
                new []{ 'a', 'b', 'b', 'a' },
                new []{ 'a', 'a', 'a', 'a' },
            };
            var sl = new Solution();
            sl.ContainsCycle(input).ShouldBe(true);
        }
        [Fact]
        public void Test2()
        {
            char[][] input = new char[][]
            {
                new []{ 'b', },
                new []{ 'b', },
            };
            var sl = new Solution();
            sl.ContainsCycle(input).ShouldBe(false);
        }
    }
}