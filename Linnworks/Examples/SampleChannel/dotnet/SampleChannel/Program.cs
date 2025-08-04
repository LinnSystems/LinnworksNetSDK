using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Serilog;
using Serilog.Filters;
using SampleChannel.Adapters;
using SampleChannel.Config;
using SampleChannel.Helpers;

var builder = WebApplication.CreateBuilder(args);

// ---- Logging Setup (optional: conditional by env) ----
var env = builder.Environment;

var loggerConfig = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Logger(lc => lc
        // General log file excluding request/response logging
        .Filter.ByExcluding(Matching.FromSource<RequestResponseLoggingMiddleware>())
        .WriteTo.File("Logs/log-.txt", rollingInterval: RollingInterval.Day)
    )
    .WriteTo.Logger(lc => lc
        // Request/Response logging
        .Filter.ByIncludingOnly(Matching.FromSource<RequestResponseLoggingMiddleware>()) // Filter logs
        .WriteTo.File("Logs/request-response-.txt", rollingInterval: RollingInterval.Day) // Specific log
    );

if (env.IsDevelopment())
{
    loggerConfig
        .WriteTo.Console();
}

Log.Logger = loggerConfig.CreateLogger();
builder.Host.UseSerilog();

// ---- Configuration ----
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

// ---- Controllers + JSON Options ----
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        options.JsonSerializerOptions.Converters.Add(new FlexibleDateTimeConverter());
    });

// ---- Swagger ----
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "SampleChannel", Version = "v1" });
});

// ---- DI Registrations ----
builder.Services.AddSingleton<IConfigStages, ConfigStages>();
builder.Services.AddSingleton<IUserConfigAdapter, UserConfigAdapter>();

var app = builder.Build();

// ---- HTTP Request Pipeline ----

if (env.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    // Note: Using Swagger causes "POST requests are not supported" output when POSTing to /Order/Orders
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SampleChannel v1"));
}
else
{
    app.UseHttpsRedirection();
}

// Consider putting this only in IsDevelopment mode
app.UseMiddleware<RequestResponseLoggingMiddleware>();

app.UseStaticFiles(); // Serve wwwroot

app.UseSerilogRequestLogging(); // Optional: log HTTP requests

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
