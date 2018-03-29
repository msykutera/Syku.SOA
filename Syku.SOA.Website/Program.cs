using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Syku.SOA
{
    public class Program
    {
        public static void Main(string[] args) => BuildWebHost(args).Run();

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls(Urls.Website)
                .UseStartup<Startup>()
                .Build();
    }
}