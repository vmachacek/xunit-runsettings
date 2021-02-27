using System;
using Xunit;

namespace TestProject1
{
    using System.Collections.Generic;
    using Microsoft.Extensions.Configuration;
    using Shouldly;

    public class UnitTest1
    {
        private IConfigurationRoot configuration;

        [Fact]
        public void Test1()
        {
            var builder = new ConfigurationBuilder()
                .AddEnvironmentVariables();

            this.configuration = builder
                .Build();
            
            this.configuration["RunPreset"].ShouldBe("Local");
        }
    }
}