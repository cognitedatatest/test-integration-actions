using System;

namespace IntegrationSampleService
{
    public class SampleService
    {
        public static string ReadEnvVar(string name)
        {
            Console.WriteLine($"Reading {name} ...");
            return Environment.GetEnvironmentVariable(name);
        }
    }
}
