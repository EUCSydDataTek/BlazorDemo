using BlazorServerDI.Components;
using DISharedServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Singleton
builder.Services.AddSingleton<ITodoService, TodoService>();

// Scoped
// In Blazor Server, a Scoped service is created once per user connection. This means that each user session (or SignalR connection) gets its own instance of the service.
// If you open two browser instances (e.g., two separate tabs or windows), each instance will establish its own SignalR connection to the server. As a result, each browser instance will get its own separate instance of the TodoService.
//builder.Services.AddScoped<ITodoService, TodoService>();

// Trancient
//builder.Services.AddTransient<ITodoService, TodoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
