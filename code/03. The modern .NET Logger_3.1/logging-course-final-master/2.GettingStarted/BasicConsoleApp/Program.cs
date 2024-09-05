using Microsoft.Extensions.Logging;

#region secret 🤭

using var loggerFactory = LoggerFactory.Create(builder =>
{
    builder.AddConsole();
});

ILogger<Program> CreateLogger()
{
    return loggerFactory.CreateLogger<Program>();
}
#endregion

ILogger logger = CreateLogger();

logger.LogInformation("Hello world!");
