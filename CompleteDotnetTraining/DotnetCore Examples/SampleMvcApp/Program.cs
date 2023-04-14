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
            //builder.Services.AddMvc();
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=First}/{action=TestMe}/{id?}"
            );

            app.Run();
        }
    }
}