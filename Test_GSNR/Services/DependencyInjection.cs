using Microsoft.EntityFrameworkCore;
using Test_GSNR.Data;

namespace Test_GSNR.Services
{
    public static class DependencyInjection
    {
		public static IServiceCollection AddInfrastructure(
		this IServiceCollection services,
		ConfigurationManager configuration)
		{
			services.AddDbContextPool<NotesDb>(options =>
			{
				options.UseSqlServer(configuration.GetConnectionString("SqlServer"));
			});


			return services;
		}
	}
}
