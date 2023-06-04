﻿namespace SquadML.Application.Logger
{
    public class LogMessage
    {
        public LogMessage(LogType severity, string message, Exception? exception = null)
        {
            Severity = severity;
            Message = message;
            Exception = exception;
        }
        public LogType Severity { get; }
        public string Message { get; }
        public Exception? Exception { get; }
        public bool HasException => Exception != null;
    }
}
