using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

class Program
{
    static void Main(string[] args)
    {
        var host = new HostBuilder()     
                .ConfigureFunctionsWebApplication() 
                .ConfigureServices(services =>
                {
                    services.AddLogging(logging => logging.AddConsole());

                })
            ;

        host.Build().Run();
    }
}