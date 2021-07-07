using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using HelloWorldAspNetCoreWebApi.Models;
using Microsoft.OpenApi.Models;

namespace HelloWorldAspNetCoreWebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // 이 메서드는 런타임에 의해 호출됩니다. 이 방법을 사용하여 컨테이너에 서비스를 추가합니다.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HelloWorldAspNetCoreWebApi", Version = "v1" });
            });

            // DI 컨테이너에 데이터베이스 컨텍스트를 추가 및 데이터베이스 컨텍스트가 메모리 내 데이터베이스를 사용하도록 지정
            services.AddDbContext<TodoContext>(opt => opt.UseInMemoryDatabase("TodoList"));
        }

        // 이 메서드는 런타임에 의해 호출됩니다. 이 방법을 사용하여 HTTP 요청 파이프 라인을 구성합니다.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HelloWorldAspNetCoreWebApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}