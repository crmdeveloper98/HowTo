using System;
using HowToAPI.Models;
using Xunit;

namespace HowToAPI.Tests
{
    public class CommandTests : IDisposable
    {
        private Command testCommand;

        public CommandTests()
        {
            
            testCommand = new Command
            {
                HowTo = "Do something awesome",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            };
        }

        [Fact]
        public void CanChangeHowTo()
        {
            // Arrange

            // Act
            testCommand.HowTo = "Execute Unit Tests";

            // Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            // Arrage

            //Act
            testCommand.Platform = "xUnit";

            // Assert
            Assert.Equal("xUnit", testCommand.Platform);
        }


        [Fact]
        public void CanChangeCommandLine()
        {
            // Arrange

            //Act
            testCommand.CommandLine = "dotnet test";

            // Assert
            Assert.Equal("dotnet test", testCommand.CommandLine);
        }

        public void Dispose()
        {
            testCommand = null;
        }
    }
}
