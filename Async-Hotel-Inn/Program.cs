using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Async_Hotel_Inn.Data;
using Async_Hotel_Inn.Models;
using Async_Hotel_Inn.Models.Interfaces;
using Async_Hotel_Inn.Models.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
namespace Async_Inn_Hotel_Management_System;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews().AddJsonOptions(options => {
            options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
            options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
        });

        builder.Services.AddSwaggerGen(options =>
        {
            // Make sure get the "using Statement"
            options.SwaggerDoc("v1", new OpenApiInfo()
            {
                Title = "Async Inn",
                Version = "v1",
            });
        });

        builder.Services.AddIdentityCore<ApplicationUser>().AddEntityFrameworkStores<AsyncInnContext>();

        //builder.Services.AddDefaultIdentity<ApplicationUser>()
        //        .AddEntityFrameworkStores<AsyncInnContext>();

        builder.Services.AddDbContext<AsyncInnContext>(options =>
            options.UseSqlServer(
                builder.Configuration
                .GetConnectionString("DefaultConnention")), ServiceLifetime.Scoped);
        builder.Services.AddTransient<IHotel, HotelService>();


        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthorization();


        app.UseSwagger(options => {
            options.RouteTemplate = "/api/{documentName}/swagger.json";
        });



        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/api/v1/swagger.json", "Async Inn Hotel");
            options.RoutePrefix = "docs";
        });


        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}"
            );
        app.Run();
    }
}
