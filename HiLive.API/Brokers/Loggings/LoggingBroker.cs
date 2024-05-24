using HiLive.API.Brokers.Loggins;
using Microsoft.Extensions.Logging;
using System;

namespace HiLive.API.Brokers.Loggings
{
    public class LoggingBroker : ILoggingBroker
    {
        private readonly ILogger<LoggingBroker> logger;
        public void LogCritical(Exception exception) =>
            this.logger.LogCritical(exception, exception.Message);


        public void LogDebug(string message)
        {
            throw new NotImplementedException();
        }

        public void LogError(Exception exception) =>
            this.logger.LogError(exception, exception.Message);


        public void LogInformation(string message) =>
            this.logger.LogInformation(message);


        public void LogTrace(string message) =>
            this.logger.LogTrace(message);


        public void LogWarning(string message) =>
            this.logger.LogWarning(message);
    }
}
