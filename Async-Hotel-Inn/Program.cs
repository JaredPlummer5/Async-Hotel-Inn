using System.Text.Json;
using System.Text.Json.Serialization;
using Async_Hotel_Inn.Data;
using Async_Hotel_Inn.Models;
using Async_Hotel_Inn.Models.Interfaces;
using Async_Hotel_Inn.Models.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace Async_Inn_Hotel_Management_System;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews().AddJsonOptions(options =>
        {
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

        builder.Services.AddAuthentication(options =>
        {
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
          .AddJwtBearer(options =>
          {
              // Tell the authenticaion scheme "how/where" to validate the token + secret
              options.SaveToken = true;
              options.TokenValidationParameters = JwtTokenService.GetValidationParameters(builder.Configuration);
          });
        builder.Services.AddAuthorization(options =>
    {

        // Add "Name of Policy", and the Lambda returns a definition
        options.AddPolicy("DistrictManager", policy =>
                policy.RequireClaim("permissions", "create", "update", "delete", "read")
                    .RequireRole("DistrictManager"));
        // options.AddPolicy("PropertyManager", policy => policy.RequireRole("PropertyManager"));

        options.AddPolicy("PropertyManager", policy =>
            policy.RequireClaim("permissions", "update", "read", "create")
                .RequireRole("PropertyManager"));

        options.AddPolicy("Agent", policy =>
            policy.RequireClaim("permissions", "update", "read")
                .RequireRole("Agent"));

        options.AddPolicy("Anonymous", policy =>
            policy.RequireClaim("permissions", "read")
                .RequireRole("Anonymous"));
    });

        builder.Services.AddDbContext<AsyncInnContext>(options =>
            options.UseSqlServer(
                builder.Configuration
                .GetConnectionString("LocalConnection")), ServiceLifetime.Scoped);

        builder.Services.AddTransient<IHotel, HotelService>();
        //builder.Services.AddIdentityCore<ApplicationUser>().AddEntityFrameworkStores<AsyncInnContext>();

        builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<AsyncInnContext>()
    .AddDefaultTokenProviders();
        builder.Services.AddScoped<JwtTokenService>();

      //  builder.Services.AddSingleton<JwtTokenService>();
        // If you want to configure default identity options
        builder.Services.Configure<IdentityOptions>(options =>
        {
        });

        builder.Services.AddControllers(
            opt => {
                var policy = new AuthorizationPolicyBuilder("Bearer").RequireAuthenticatedUser().Build();
                opt.Filters.Add(new AuthorizeFilter(policy));

            }
            );
        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");

        app.UseRouting();
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseAuthentication();
        app.UseAuthorization();

        //builder.Services.AddAuthentication(options =>
        //{
    
        //}).AddJwtBearer(options =>
        //{
           
        //});





      

        app.UseSwagger(options =>
        {
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
