using CallManagement.DataAccess.Interfaces;
using CallManagement.DataAccess.Services;
using Delivery.DataAccess.Infrastructure;
using DeliveryAppWebApi.DAL.Interfaces.SQLInterfaces.ISQLRepositories;
using DeliveryAppWebApi.DAL.Interfaces.SQLInterfaces.ISQLServices;
using DeliveryManagement.DataAccess.Interfaces;
using DeliveryManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;
using DeliveryManagement.DataAccess.Interfaces.SQLInterfaces.ISQLServices;
using DeliveryManagement.DataAccess.Repositories;
using DeliveryManagement.DataAccess.Repositories.SQL_Repositories;
using DeliveryManagement.DataAccess.Services;
using DeliveryManagement.DataAccess.Services.SQL_Services;
using DeliveryManagement.DataAccess.sqlunitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DeliveryAppWebApi
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
            
            services.AddDbContext<ApplicationContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );

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

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}