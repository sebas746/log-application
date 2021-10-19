using LogApplication.Core.Logger;
using Moq;
using System;
using Xunit;

namespace LogApplication.Test.Logger
{
    public class LoggerServiceTest
    {
        readonly LoggerService _loggerService;
        public LoggerServiceTest()
        {
            _loggerService = new LoggerService();
        }

        [Fact]
        public void LogInfoSuccesfully()
        {
            //Arrange
            var message = "Info Message";
            var logType = "INFO";

            //Act
            var response = _loggerService.LogMessage(message, logType);

            //Asserts
            Assert.True(response);
        }

        [Fact]
        public void LogWarningSuccesfully()
        {
            //Arrange
            var message = "Warning Message";
            var logType = "WARNING";

            //Act
            var response = _loggerService.LogMessage(message, logType);

            //Asserts
            Assert.True(response);
        }

        [Fact]
        public void LogErrorSuccesfully()
        {
            //Arrange
            var message = "Error Message";
            var logType = "ERROR";

            //Act
            var response = _loggerService.LogMessage(message, logType);

            //Asserts
            Assert.True(response);
        }

        [Fact]
        public void LogTypeError()
        {
            //Arrange
            var message = "Other Message";
            var logType = "OTHER";

            //Act

            //Asserts
            Assert.Throws<ArgumentException>(() => _loggerService.LogMessage(message, logType));
        }
    }
}
