using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
    .AddUserSecrets<Program>();

IConfiguration configuration = builder.Build();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine("User Secrets");
Console.WriteLine("------------");
Console.ForegroundColor = ConsoleColor.Magenta;
var apiKeyValue = configuration["ApiKey"] ?? string.Empty;
Console.WriteLine($"ApiKey: {apiKeyValue}");
Console.WriteLine();
