using Microsoft.AspNetCore.Routing.Constraints;

namespace FirstProjectMVC

                                        
                                                        
              


{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.UseRouting();
            app.MapGet("/", async context => // Static Segment
            {
                await context.Response.WriteAsync("Hello World!");
            });

            app.MapGet("/Fixed{name}", async context => //Variable Segment
            {
                var name = context.Request.RouteValues["name"];
                await context.Response.WriteAsync($"hello Fixed {name}");
            });
            app.MapGet("/{name}", async context => //Variable Segment
            {
                var name = context.Request.RouteValues["name"];
                await context.Response.WriteAsync($"hello {name}");
            });

            app.MapGet("/GetMovie", async context => //Variable Segment


            {


            });



            app.MapControllerRoute(
                name: "Rafat",
                pattern: "{controller=Movies}/{action=GetMovies}/{id}/{name}/"
            );

            app.MapAreaControllerRoute(
           name: "default",
           areaName: "YourArea",
           pattern: "{controller}/{action}/{id?}",  // ? it mean it is not required
           defaults: new { controller = "movies", action = "Index" }
           //constraints : new {id = @"\d{2}"} // Can add more than constrains
          //constraints: new { id = new IntRouteConstraint() }
          // can make 
          //pattern: "{controller}/{action}/{id:int?}"
          //pattern: "{controller}/{action}/{id:regex(^\\d{{2}})?}"
          );

            app.Run();
        }
    }
}
