using System;
using ChecklistApp.API.Data;
using ChecklistApp.API.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ChecklistApp.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host= CreateWebHostBuilder(args).Build();
            using ( var scope= host.Services.CreateScope())
            {
                var services=scope.ServiceProvider;
                try
                {
                    var context=services.GetRequiredService<DataContext>();
                    var userManager=services.GetRequiredService<UserManager<User>>();
                    context.Database.Migrate();
                    Seed.SeedUsers(userManager);
                }
                catch (Exception ex)
                {
                    var logger= services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex,"An error ocurred during migration");
                }
           }

           host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
