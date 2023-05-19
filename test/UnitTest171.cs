using Namespace171;
using Shouldly;

namespace LeetCodeTest
{
    public class UnitTest171
    {
        [Fact]
        public void Test1()
        {
            var sl = new Solution();
            sl.TitleToNumber("A").ShouldBe(1);
            sl.TitleToNumber("AB").ShouldBe(28);
            sl.TitleToNumber("ZY").ShouldBe(701);
            sl.TitleToNumber("FXSHRXW").ShouldBe(2147483647);
        }
      
    }
}