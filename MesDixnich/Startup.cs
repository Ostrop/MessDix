//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//namespace SignalRApp
//{
//    public class Startup
//    {
//        public void ConfigureServices(IServiceCollection services)
//        {
//            services.AddSignalR();
//            services.AddRazorPages();
//        }

//        public void Configure(IApplicationBuilder app)
//        {

//            app.UseDefaultFiles();
//            app.UseStaticFiles();

//            app.UseRouting();

//            app.UseEndpoints(endpoints =>
//            {
//                endpoints.MapHub<ChatHub>("/chat");
//            });
//        }
//    }
//}
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace EmptyRazorPagesApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();   // ��������� ������� Razor Pages
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();  // ��������� ������������� ��� RazorPages
            });
        }
    }
}