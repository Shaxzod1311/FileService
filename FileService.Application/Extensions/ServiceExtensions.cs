using FileService.Application.Data;
using Microsoft.EntityFrameworkCore;
namespace FileService.Application.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<FileServiceDb>(options =>
            {
                options.UseNpgsql(configuration.GetValue<string>("Database:ConnectionStrings:Postgres"));
            });
        }
    }
}
