using System;

namespace IntegrationSampleService
{
    public class SampleService
    {
        public static string ReadEnvVar(string name)
        {
            Console.Write($"Reading {name}...");
            return Environment.GetEnvironmentVariable(name);
        }
    }
}
