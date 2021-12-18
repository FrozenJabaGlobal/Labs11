using Xunit;

namespace BLL.Tests
{
    public class RegexServiceTests
    {
        [Fact]
        public void Check_Success()
        {
            RegexService regex = new RegexService(@"[A-Z]{1}[a-z]+$");

            Assert.True(regex.Check("Foo"));
        }

        [Fact]
        public void Check_Unsuccess()
        {
            RegexService regex = new RegexService(@"[A-Z]{1}[a-z]+$");

            Assert.False(regex.Check("foo"));
        }
    }
}