using Namespace168;

namespace LeetCodeTest
{
    public class UnitTest168
    {
        [Fact]
        public void Test1()
        {
            var sl = new Solution();
            sl.ConvertToTitle(1).ShouldBe("A");
            sl.ConvertToTitle(28).ShouldBe("AB");
            sl.ConvertToTitle(701).ShouldBe("ZY");
            sl.ConvertToTitle(2147483647).ShouldBe("FXSHRXW");
        }
      
    }
}