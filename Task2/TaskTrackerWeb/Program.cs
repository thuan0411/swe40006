using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using TaskTrackerWeb.Models;
using TaskTrackerWeb.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<ITaskService, TaskService>();

// Task 2.3: DemoSettings now comes from configuration — appsettings.json
// locally, and Azure App Service "Application settings" (environment
// variables) in production. No secrets are hardcoded in source anymore.
builder.Services.Configure<DemoSettings>(builder.Configuration.GetSection("DemoSettings"));

// Task 2.3: active health check endpoint for Azure App Service diagnostics.
builder.Services.AddHealthChecks();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapHealthChecks("/health", new HealthCheckOptions
{
    ResponseWriter = async (context, report) =>
    {
        context.Response.ContentType = "application/json";
        var payload = System.Text.Json.JsonSerializer.Serialize(new
        {
            status = report.Status.ToString(),
            checks = report.Entries.Select(e => new { name = e.Key, status = e.Value.Status.ToString() }),
            totalDurationMs = report.TotalDuration.TotalMilliseconds,
            timestampUtc = DateTime.UtcNow
        });
        await context.Response.WriteAsync(payload);
    }
});

app.Run();
