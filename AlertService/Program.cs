using AlertService.Supervisors;
using AlertService.Workers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AlertService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    //services.AddHostedService<RefreshSymbolsWorker>();
                    //services.AddTransient<ISymbolSupervisor, SymbolSupervisor>();

                    //services.AddHostedService<CheckPriceChangesWorker>();
                    //services.AddTransient<IPriceChangeSupervisor, PriceChangeSupervisor>();
                });
    }
}
