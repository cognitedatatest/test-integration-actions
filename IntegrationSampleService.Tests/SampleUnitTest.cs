using System;
using Xunit;

namespace IntegrationSampleService.Tests
{
    public class SampleUnitTest
    {
        [Theory]
        [InlineData("PATH")]
        [Trait("Category", "Unit")]
        public void TestEnv(string varName)
        {
            var varValue = SampleService.ReadEnvVar(varName);
            Console.WriteLine($"{varName} = {varValue}");
            Assert.NotNull(varValue);
        }
    }
}
