using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;
using Vending.Data;
using Vending.Services;
using Vending.NetCore.VueCoreConnection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSpaStaticFiles(options => options.RootPath = "frontend/dist");

// Add services to the container.
builder.Services.AddRazorPages();
var connectionString = builder.Configuration.GetConnectionString("ProductionMovieContext");

if (connectionString is not null) {
    builder.Services.AddDbContext<VendingContext>(options =>
        options.UseMySQL(connectionString));
}

builder.Services.AddScoped<IOrderService, OrderServiceImpl>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Order}/{action=Index}/"
);

app.UseSpaStaticFiles();
app.UseSpa(spa =>
{
    spa.Options.SourcePath = "frontend";
    if (builder.Environment.IsDevelopment()) {
        spa.UseVueDevelopmentServer();
    }
}); 

app.Run();
