using System.Diagnostics;
using System.Web.Http.ExceptionHandling;

namespace Calculator.Api
{
    public class GlobalExceptionLogger : ExceptionLogger
    {
        private readonly ILogger? _logger;
        public override void Log(ExceptionLoggerContext context)
        {
            _logger?.LogError("Unhandled exception processing {0} for {1}: {2}",
            context.Request.Method,
            context.Request.RequestUri,
            context.Exception);
        }
    }
}
