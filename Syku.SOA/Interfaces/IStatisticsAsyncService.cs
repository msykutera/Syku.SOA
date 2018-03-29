using System;
using System.Threading.Tasks;

namespace Syku.SOA
{
    public interface IStatisticsAsyncService
    {
        Task<Statistics> GetStatistics(DateTime from, DateTime to);
    }
}