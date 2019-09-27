using System;

namespace Vysn.Comons
{
    /// <summary>
    /// 
    /// </summary>
    public readonly struct LogMessage
    {
        /// <summary>
        /// 
        /// </summary>
        public string Source { get; }

        /// <summary>
        /// 
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// 
        /// </summary>
        public Exception Exception { get; }

        /// <summary>
        /// 
        /// </summary>
        public LogLevel Level { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        /// <param name="level"></param>
        public LogMessage(string source = null, string message = null,
            Exception exception = null,
            LogLevel level = default)
        {
            Source = source;
            Message = message;
            Exception = exception;
            Level = level;
        }
    }
}