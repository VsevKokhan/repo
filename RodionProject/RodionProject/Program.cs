using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using RodionProject.Services;
using Telegram.Bot;

namespace RodionProject;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();
        // Регистрируем TelegramBotService
        builder.Services.AddSingleton<TelegramBotService>();
        
        var app = builder.Build();

        app.UseStaticFiles();

        app.UseRouting();
        
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}