using System.Xml.Linq;

namespace ASPCora__viewimport
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            app.MapControllerRoute(
                    name :"defult",
                    pattern :"{controller=Home}/{action=index}/{id?}"
                );
            


            

            app.Run();
        }
    }
}
