using Microsoft.EntityFrameworkCore;
using Test_GSNR.Data;
using Test_GSNR.Data.Repository;
using Test_GSNR.Services.Repositories;

namespace Test_GSNR.Services;

public static class DependencyInjection
    {
	public static IServiceCollection AddInfrastructure(
	this IServiceCollection services,
	ConfigurationManager configuration)
	{
		services.AddScoped<INotesRepository, NoteRepository>();

		services.AddDbContextPool<NotesDb>(options =>
		{
			options.UseSqlServer(configuration.GetConnectionString("SqlServer"));
		});

		return services;
	}
}
