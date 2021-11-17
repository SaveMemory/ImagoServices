using System;
using Imago.BusinessLogic.Employee.Read;
using Imago.BusinessLogic.Employee.Read.Abstract;
using Imago.DataAccess.Database;
using Imago.DataAccess.Repositories.Read;
using Imago.DataAccess.Repositories.Read.Abstract;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Imago.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));

            #region Read

            services.AddScoped<IEmployeeReadService, EmployeeReadService>();
            services.AddScoped<IEmployeeReadRepository, EmployeeReadRepository>();

            #endregion


            services.AddCors(x => x.AddPolicy("ImagoCorsPolicy", builder =>
            {
                builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
            }));


            services.AddDbContext<ImagoContext>(options => options.UseInMemoryDatabase(databaseName: "Imago"));
            services.AddControllers();
            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo {Title = "Imago.Api", Version = "v1"}); });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Imago.Api v1"));
            }

            using (var context = new ImagoContext(serviceProvider.GetRequiredService<DbContextOptions<ImagoContext>>()))
            {
                InMemorySeed.CreateSeed(context);
            }
            
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("ImagoCorsPolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
