using Eimbee.DataAccessLayer;
using Eimbee.DataAccessLayer.Repository;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace Eimbee.Server
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
            AddDatabase(services);
            services.AddControllers();
            services.AddLogging();
            services.AddMediatR(typeof(Startup));
            AddDependencies(services);                        
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
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        public void AddDependencies(IServiceCollection services)
        {
            services.AddTransient<IAircraftRepository, AircraftRepository>();
            services.AddTransient<ICityRepository, CityRepository>();
            services.AddTransient<IAircraftTypeRepository, AircraftTypeRepository>();
            services.AddTransient<IAirlineRepository, AirlineRepository>();
            services.AddTransient<IAirlineRouteRepository, AirlineRouteRepository>();
            services.AddTransient<IPilotRepository, PilotRepository>();
            services.AddTransient<IAirportRepository, AirportRepository>();
            services.AddTransient<ICountryRepository, CountryRepository>();

        }
        public void AddDatabase(IServiceCollection services)
        {
            services.AddDbContext<DatabaseContext>(options =>
                    options.UseSqlServer(Configuration.GetValue<string>("Db:Connectionstring"),
                        migration => migration.MigrationsHistoryTable("MigrationHistory")),
                ServiceLifetime.Transient);
        }
    }
}
