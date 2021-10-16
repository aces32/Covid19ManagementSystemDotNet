using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace COVID_19PCR.TestManagement.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<COVID19PCRDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("COVID19PCRConnectionString")));

            services.AddDbContext<COVID19PCRDbContext>(options =>
            {
                object p = options.UseInMemoryDatabase("COVID19PCRDbContextInMemoryTest");
            });

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IAdminBookingAllocationRepository, AdminBookingAllocationRepository>();
            services.AddScoped<IIndividualLabRepository, IndividualLabRepository>();
            services.AddScoped<IIndividualRepository, IndividualRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();

            return services;
        }
    }
}
