using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SuperProductsCatalog.API.Model.Data;

namespace SuperProductsCatalog.API
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
            // IoC Reg

            

            services.AddDbContext<SuperProductsDbContext>(options => 
            {
                options.UseSqlServer(Configuration.GetConnectionString("default"));
            });

            // create a CORS policy
            services.AddCors(options => 
            {
                options.AddPolicy(name: "mypolicy1",
                    b=>b.AllowAnyOrigin());
                    //b => b.WithOrigins("www.abc.com"));
            }
            );

            services.AddCors(options =>
            {
                options.AddPolicy(name: "mypolicy2",
                    //b => b.AllowAnyOrigin());
                b => b.WithOrigins("www.abc.com"));
            }
            );

            services.AddControllers().AddXmlSerializerFormatters().AddNewtonsoftJson();
            services.AddOData();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SuperProductsCatalog.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SuperProductsCatalog.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("mypolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.EnableDependencyInjection();
                endpoints.Select().OrderBy().Filter().MaxTop(10).SkipToken().Expand();

                endpoints.MapControllers();
            });
        }
    }
}
