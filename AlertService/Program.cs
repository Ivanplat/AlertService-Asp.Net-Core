using AlertService.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IAlert, XmlAlert>();
var app = builder.Build();

app.MapGet("/", async context =>
{
    context.Response.ContentType = "text/html;charset=utf-8";
    string html = string.Empty;
    foreach(var service in builder.Services)
    {
        html += $"Service type: {service.ServiceType.FullName}<br>";
        html += $"Lifetime: {service.Lifetime}<br>";
        html += $"Implementation type: " +
        $"{service.ImplementationType?.FullName}<br><br>";
    }

    await context.Response.WriteAsync(html);
});

app.Run();
