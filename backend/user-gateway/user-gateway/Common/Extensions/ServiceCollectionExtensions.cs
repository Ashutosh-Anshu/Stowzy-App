using Microsoft.EntityFrameworkCore;
using user_gateway.BLL.Application.Helpers;
using user_gateway.BLL.Application.Mappings;
using user_gateway.BLL.Application.Services.Account;
using user_gateway.DAL.Infrastructure.Persistence;
using user_gateway.DAL.Infrastructure.Repositories.Account;

namespace user_gateway.Common.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddCors();
            services.Configure<CloudinarySettings>(configuration.GetSection("CloudinarySettings"));

            // Common 
            services.AddScoped<ICloudinaryService, CloudinaryService>();

            // Repositories here
            services.AddScoped<IAccountRepository, AccountRepository>();

            // Services here
            services.AddScoped<IAccountService, AccountService>();

            // AutoMapper
            services.AddAutoMapper(typeof(OwnerMappingProfile));// Replace 'Program' if necessary

            return services;
        }



    }
}
