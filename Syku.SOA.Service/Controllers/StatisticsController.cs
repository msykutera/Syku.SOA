using Microsoft.AspNetCore.Mvc;
using System;

namespace Syku.SOA.Provider
{
    [Route("api/[controller]")]
    public class StatisticsController : Controller
    {
        private readonly IStatisticsService _statisticsService;

        public StatisticsController(IStatisticsService statisticsService)
        {
            _statisticsService = statisticsService;
        }

        [HttpGet("get/{from}/{to}")]
        public Statistics GetStatistics(DateTime from, DateTime to)
        {
            var result = _statisticsService.GetStatistics(from, to);
            return result;
        }
    }
}