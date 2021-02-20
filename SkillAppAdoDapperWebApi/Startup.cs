using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CallManagement.DataAccess.Interfaces;
using CallManagement.DataAccess.Services;
using DeliveryAppAdoDapperWebApi.DAL.Interfaces.SQLInterfaces.ISQLServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SkillAppAdoDapperWebApi.DAL.Interfaces.SQLInterfaces.ISQLRepositories;
using SkillManagement.DataAccess.Entities.SQLEntities;
using SkillManagement.DataAccess.Infrastructure;
using SkillManagement.DataAccess.Interfaces;
using SkillManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;
using SkillManagement.DataAccess.Interfaces.SQLInterfaces.ISQLServices;
using SkillManagement.DataAccess.Repositories;
using SkillManagement.DataAccess.Repositories.SQL_Repositories;
using SkillManagement.DataAccess.Services;
using SkillManagement.DataAccess.Services.SQL_Services;
using SkillManagement.DataAccess.sqlunitOfWork;

namespace DeliveryAppAdoDapperWebApi
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
            services.AddControllers();

            #region SQL repositories
            services.AddTransient<ISqlClientRepository, SqlClientRepository>();
            services.AddTransient<ISqlDeliveryMenRepository, SqlDeliveryMenRepository>();
            services.AddTransient<ISqlCallRepository, SqlCallRepository>();
            services.AddTransient<ISqlCarRepository, SqlCarRepository>();
            services.AddTransient<ISqlOrderRepository, SqlOrderRepository>();
            #endregion

            #region SQL services
            services.AddTransient<ISqlClientService, SqlClientService>();
            services.AddTransient<ISqlDeliveryMenService, SqlDeliveryMenService>();
            services.AddTransient<ISqlCallService, SqlCallService>();
            services.AddTransient<ISqlOrderService, SqlOrderService>();
            services.AddTransient<ISqlCarService, SqlCarService>();
            #endregion

            services.AddTransient<ISQLunitOfWork, SQLsqlunitOfWork>();

            services.AddTransient<IConnectionFactory, ConnectionFactory>();

            services.AddSingleton<IConfiguration>(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
