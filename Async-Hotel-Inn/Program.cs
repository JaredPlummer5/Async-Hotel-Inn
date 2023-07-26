using System;
using Async_Hotel_Inn.Data;
using Microsoft.EntityFrameworkCore;
namespace Async_Inn_Hotel_Management_System;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();

        builder.Services.AddDbContext<AsyncInnContext>(options =>
            options.UseSqlServer(
                builder.Configuration
                .GetConnectionString("DefaultConnection")));

        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}"
            );
        app.Run();
    }
}
