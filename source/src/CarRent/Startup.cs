using AutoMapper;
using CarRent.CarManagement.Application;
using CarRent.CarManagement.Domain;
using CarRent.CarManagement.Infrastructure;
using CarRent.CustomerManagement.Application;
using CarRent.CustomerManagement.DbContext;
using CarRent.CustomerManagement.Domain;
using CarRent.CustomerManagement.Infrastructure;
using CarRent.ReservationManagement.Application;
using CarRent.ReservationManagement.Domain;
using CarRent.ReservationManagement.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace CarRent
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
            string mySqlConnectionStr = Configuration.GetConnectionString("DefaultConnection");  
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CarRent", Version = "v1" });
            });
            services.AddDbContextPool<CarRentDBContext>(options => options.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr)));

            services.AddTransient<ICustomerService, CustomerService>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            services.AddTransient<ICarService, CarService>();
            services.AddScoped<ICarRepository, CarRepository>();

            services.AddTransient<IReservationService, ReservationService>();
            services.AddScoped<IReservationRepository, ReservationRepository>();

            services.AddAutoMapper(typeof(Startup));
            services.AddCors(o => o.AddPolicy("charppolicy", builder =>  
            {  
                builder.AllowAnyOrigin()  
                    .AllowAnyMethod()  
                    .AllowAnyHeader();  
            }));  
  

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CarRent v1"));
            }

            app.UseCors("charppolicy");  

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
