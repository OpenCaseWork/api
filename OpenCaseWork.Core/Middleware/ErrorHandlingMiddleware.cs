using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OpenCaseWork.Core.Exceptions;
using OpenCaseWork.Models;

namespace OpenCaseWork.Core.Middleware
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private static ILogger _logger;

        public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            if (exception == null) return;

            var code = HttpStatusCode.InternalServerError;

            if (exception is ObjectNotFoundException) code = HttpStatusCode.NotFound;
            else if (exception is UnauthorizedAccessException) code = HttpStatusCode.Unauthorized;
            else if (exception is NotImplementedException) code = HttpStatusCode.NotImplemented;

            _logger.LogError((int)code, exception, exception.Message);


            await WriteExceptionAsync(context, exception, code).ConfigureAwait(false);
        }

        private static async Task WriteExceptionAsync(HttpContext context, Exception exception, HttpStatusCode code)
        {
            var response = context.Response;
            response.ContentType = "application/json";
            response.StatusCode = (int)code;
            await response.WriteAsync(JsonConvert.SerializeObject(new
            {
                error = new ResponseStatus
                {
                    Message = exception.Message,
                    StatusCode = (int) code,
                    StackTrace = exception.StackTrace
                }
            })).ConfigureAwait(false);
        }
    }
}

