using System;
using Xunit;

namespace IntegrationSampleService.Tests
{
    public class SampleIntegrationTest
    {
        [Theory]
        [InlineData("REPO_SECRET")]
        [Trait("Category", "Integration")]
        public void TestSecret(string varName)
        {
            var varValue = SampleService.ReadEnvVar(varName);
            Console.WriteLine($"{varName} = {varValue}");
            Assert.NotNull(varValue);
        }
    }
}
