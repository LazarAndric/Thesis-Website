using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Commander.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Commander
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Context>(
                optUser =>optUser.UseSqlServer(Configuration.GetConnectionString("Connection"))
            );
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(opt =>{
                    opt.Audience = Configuration["AAD:ResourceId"];
                    opt.Authority = $"{Configuration["AAD:InstanceId"]}{Configuration["AAD:TenantId"]}";

                });
            services.AddControllers().AddNewtonsoftJson(s => { 
                s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                });
            
            services.AddScoped<ICategoryRepo, SqlCategoryRepo>();
            services.AddScoped<IUserRepo, SqlUserRepo>();
            services.AddScoped<IProductRepo, SqlProductRepo>();
            services.AddScoped<IProductOfUserRepo, SqlProductOfUser>();
            services.AddScoped<ISizeRepo, SqlSizeRepo>();
            services.AddScoped<ISizeOfProductRepo, SqlSizeOfProductRepo>();
            services.AddScoped<IGenderRepo, SqlGenderRepo>();
            services.AddScoped<IGenderOfProductRepo, SqlGendersOfProductRepo>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
