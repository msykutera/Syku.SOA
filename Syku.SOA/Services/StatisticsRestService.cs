using RestSharp;
using System;
using System.Threading.Tasks;

namespace Syku.SOA
{
    public class StatisticsRestService : IStatisticsAsyncService
    {
        public async Task<Statistics> GetStatistics(DateTime from, DateTime to)
        {
            var client = new RestClient(Urls.Provider);
            var request = new RestRequest($"api/statistics/get/{from.Ticks}/{to.Ticks}");
            var statistics = await client.GetTaskAsync<Statistics>(request);
            return statistics;
        }
    }
}
