using System;

namespace Async_Inn_Hotel_Management_System;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();

        //builder.Services.addContext()


        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthorization();
        
        app.MapControllerRoute(
            name:"default",
            pattern: "{controller=Home}/{action=Index}/{id?}"
            );
        app.Run();
    }
}

