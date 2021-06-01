using System;

namespace IntegrationSampleService
{
    public class SampleService
    {
        public static string ReadEnvVar(string name)
        {
            return Environment.GetEnvironmentVariable(name);
        }
    }
}
