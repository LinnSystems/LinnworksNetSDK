using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

public class RequestResponseLoggingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<RequestResponseLoggingMiddleware> _logger;

    public RequestResponseLoggingMiddleware(RequestDelegate next, ILogger<RequestResponseLoggingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task Invoke(HttpContext context)
    {
        // Log Request
        context.Request.EnableBuffering(); // allow rereading the body
        var requestBody = await new StreamReader(context.Request.Body).ReadToEndAsync();
        context.Request.Body.Position = 0; // rewind

        var isJsonRequest = context.Request.ContentType?.Contains("application/json", StringComparison.OrdinalIgnoreCase) == true;
        var prettyRequest = isJsonRequest ? TryFormatJson(requestBody) : requestBody;

        _logger.LogInformation("Request {method} {url}\nHeaders: {headers}\nBody:\n{body}",
            context.Request.Method,
            context.Request.Path,
            context.Request.Headers,
            prettyRequest);

        // Capture Response
        var originalBody = context.Response.Body;
        using var newBody = new MemoryStream();
        context.Response.Body = newBody;

        await _next(context);

        context.Response.Body.Seek(0, SeekOrigin.Begin);
        var responseBody = await new StreamReader(context.Response.Body).ReadToEndAsync();
        context.Response.Body.Seek(0, SeekOrigin.Begin);

        var isJsonResponse = context.Response.ContentType?.Contains("application/json", StringComparison.OrdinalIgnoreCase) == true;
        var prettyResponse = isJsonResponse ? TryFormatJson(responseBody) : responseBody;

        _logger.LogInformation("Response {statusCode}\nHeaders: {headers}\nBody:\n{body}",
            context.Response.StatusCode,
            context.Response.Headers,
            prettyResponse);

        await newBody.CopyToAsync(originalBody);
    }

    private static string TryFormatJson(string json)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(json))
                return json;

            var jsonDocument = JsonDocument.Parse(json);
            return JsonSerializer.Serialize(jsonDocument, new JsonSerializerOptions
            {
                WriteIndented = true
            });
        }
        catch
        {
            return json; // Return original if parsing fails
        }
    }
}