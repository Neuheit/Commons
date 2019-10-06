using System;

namespace Vysn.Commons
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
        public LogMessage(string source = null, LogLevel level = default,
            string message = null, Exception exception = null)
        {
            Source = source;
            Message = message;
            Exception = exception;
            Level = level;
        }

        /// <inheritdoc />
        public override string ToString()
            => $"{Source} {Level} {Message} {Exception}";
    }
}