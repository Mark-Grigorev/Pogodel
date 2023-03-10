using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ServiceStack.Text;

namespace Test_YouTube
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public void ConfigureServices(IServiceCollection services)
        {       //!!!!!!!!Не работает, в душе не ебу почему!!!!!!
            //Подключаем конфиг из appsetings.json
            Configuration.Bind("Project", new Config());


            //Добавление поддержки контроллеров и представлений (MVC)
            services.AddControllersWithViews()
                //Выставляется совместимость с asp.net core 3.0
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Порядок регистрации middleware очень важен
            //В процессе разработки нам важно видеть подробную информацию об ошибках

            if (env.IsDevelopment())
            {              //Сайт в разработке, вывод полной информации о ошибках
                app.UseDeveloperExceptionPage();

            }
            app.UseRouting();
            // Использование статических файлов(Css,Pictures,JS and so on)
            //app.UseStaticFiles();


            //Регистрация нужных нам маршрутов(EndPoints)
          /*  app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");


            });*/
        }
    }
}
