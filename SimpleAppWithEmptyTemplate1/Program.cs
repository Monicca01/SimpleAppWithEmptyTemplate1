var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
var app = builder.Build();

app.UseFileServer();
//app.MapGet("/", () => "Hello World!");
app.UseRouting();
app.MapRazorPages();

app.Run();
