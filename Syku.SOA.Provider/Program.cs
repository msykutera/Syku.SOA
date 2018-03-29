using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Syku.SOA.Provider
{
    public class Program
    {
        public static void Main(string[] args) => BuildWebHost(args).Run();

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls(Urls.Provider)
                .UseStartup<Startup>()
                .Build();
    }
}