using Microsoft.EntityFrameworkCore;
using PurpleBuzzAplication.DAL;

namespace PurpleBuzzAplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt => {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
            });
            var app = builder.Build();
          
            app.UseStaticFiles();
            app.MapControllerRoute(
               name: "default",
               pattern: "{controller=Home}/{action=Index}/{id?}"
               );

            app.Run();
        }
    }
}
