using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;
using Vending.Data;
using Vending.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
var connectionString = builder.Configuration.GetConnectionString("ProductionMovieContext");

if (connectionString is not null) {
    builder.Services.AddDbContext<VendingContext>(options =>
        options.UseMySQL(connectionString));
}

builder.Services.AddControllers();
builder.Services.AddScoped<IOrderService, OrderServiceImpl>();
builder.Services.AddMvc(option => option.EnableEndpointRouting = false);

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
app.UseAuthorization();
app.UseMvc();
app.UseRouting();
app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Order}/{action=Index}/"
);
app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

app.Run();
