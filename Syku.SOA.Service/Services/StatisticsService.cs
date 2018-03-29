using System;

namespace Syku.SOA.Provider
{
    public class StatisticsService : IStatisticsService
    {
        public Statistics GetStatistics(DateTime from, DateTime to)
        {
            return new Statistics
            {
                Value1 = 10,
                Value2 = 100,
                Value3 = 1000,
            };
        }
    }
}
