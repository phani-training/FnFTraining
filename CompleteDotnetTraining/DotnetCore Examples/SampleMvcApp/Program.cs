using SampleMvcApp.Models;

namespace SampleMvcApp
{
    public class Program
    {

        public static IConfiguration Configuration { get; set; }
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Configuration = new ConfigurationBuilder().Build();
            //Inject some dependencies if U want....
            //Add Services to UR Application like Mvc Service
            builder.Services.AddMvc();
            builder.Services.AddControllersWithViews();
            
            builder.Services.AddTransient<IBookStore, BookRepo>();
            var app = builder.Build();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
            );

            app.Run();
        }
    }
}