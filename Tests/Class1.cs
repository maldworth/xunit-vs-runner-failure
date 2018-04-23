using System;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class Class1 : IClassFixture<TestServerFixture>
    {
        private readonly TestServerFixture _fixture;

        public Class1(TestServerFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async Task GetValues()
        {
            var result = await _fixture.Client.GetStringAsync("api/values");

            Assert.NotEmpty(result);
        }
    }
}
