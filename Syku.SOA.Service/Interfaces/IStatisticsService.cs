using System;

namespace Syku.SOA.Provider
{
    public interface IStatisticsService
    {
        Statistics GetStatistics(DateTime from, DateTime to);
    }
}