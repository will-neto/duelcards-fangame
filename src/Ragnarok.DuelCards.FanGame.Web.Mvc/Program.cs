using Microsoft.EntityFrameworkCore;
using Ragnarok.DuelCards.FanGame.Data;

namespace Ragnarok.DuelCards.FanGame.Web.Mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            ConfigServices(builder);

            // Add app configurations
            ConfigApp(builder);
        }

        private static void ConfigServices(WebApplicationBuilder builder)
        {
            builder.Services.AddControllersWithViews();

            var connectionString = builder.Configuration.GetConnectionString("RagnarokDuelCardsConnection");

            builder.Services.AddDbContext<RagnarokDuelCardsContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
        }

        private static void ConfigApp(WebApplicationBuilder builder)
        {
            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }

    }
}
