﻿//// ---------------------------------------------------------------
//// Copyright (c) Coalition of the Good-Hearted Engineers
//// FREE TO USE TO CONNECT THE WORLD
//// ---------------------------------------------------------------

using System;

namespace HiLive.API.Brokers.Loggins
{
    public interface ILoggingBroker
    {
        void LogInformation(string message);
        void LogTrace(string message);
        void LogDebug(string message);
        void LogWarning(string message);
        void LogError(Exception exception);
        void LogCritical(Exception exception);
    }
}
