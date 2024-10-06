using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MSADBMigrations.Context;

class Program
{
    static void Main(string[] args)
    {
        var config = BuilderConfiguration(args);
        var applicationServices = CreateServiceProvider(config);
    }

    public static IConfiguration BuilderConfiguration(string[] args = null)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        return config.Build();
    }

    public static IServiceProvider CreateServiceProvider(IConfiguration configuration)
    {
        var services = new ServiceCollection()
            .AddLogging()
            .AddOptions()
            .AddDbContext<MSAContext>(options => options.UseSqlServer(configuration["ConnectionString:db_string"]));

        var applicationServices = services.BuildServiceProvider();
        // pre-resolve services that needs to be disposed in any case
        _ = applicationServices.GetService<IConfiguration>();
        return applicationServices;
    }
}