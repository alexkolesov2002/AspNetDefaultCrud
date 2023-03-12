using System.Net;
using Crud.Host.Models.Dtos;
using Newtonsoft.Json;

namespace Crud.Host.Middlewares;

public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _requestDelegate;
    private readonly ILogger<ExceptionHandlingMiddleware> _logger;

    public ExceptionHandlingMiddleware(RequestDelegate requestDelegate, ILogger<ExceptionHandlingMiddleware> logger)
    {
        _requestDelegate = requestDelegate;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await _requestDelegate(httpContext);
        }
        catch (Exception e)
        {
            await HandleExceptionAsync(httpContext,
                e.Message,
                HttpStatusCode.InternalServerError,
                "Возникло исключение");
        }
    }

    private async Task HandleExceptionAsync(HttpContext httpContext, string exceptionMessage,
        HttpStatusCode httpStatusCode, string message)
    {
        _logger.LogError(exceptionMessage);

        var response = httpContext.Response;
        response.ContentType = "application/json";
        response.StatusCode = (int)httpStatusCode;

        var errorMessageDto = new ErrorMessageDto()
        {
            ErrorMessage = message,
            StatusCode = (int)httpStatusCode
        };

        var result = errorMessageDto.ToString();
        await response.WriteAsJsonAsync(result);
    }
}