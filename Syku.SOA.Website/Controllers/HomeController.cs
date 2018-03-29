using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Syku.SOA
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly IStatisticsAsyncService _statisticsSerivce;

        public HomeController(IStatisticsAsyncService statisticsSerivce)
        {
            _statisticsSerivce = statisticsSerivce;
        }

        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var to = DateTime.Now;
            var from = to.AddMonths(-12);
            var statistics = await _statisticsSerivce.GetStatistics(from, to);
            return View(statistics);
        }
    }
}