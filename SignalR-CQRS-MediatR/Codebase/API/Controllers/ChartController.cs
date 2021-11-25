using Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartController : ApiController
    {
        //private IHubContext<ChartHubConfig> _hub;

        //public ChartController(IHubContext<ChartHubConfig> hub)
        //{
        //    _hub = hub;
        //}

        public IActionResult Get()
        {
            var result = Mediator.Send(new FetchChartDataQuery());
            //  var timerManager = new TimerManager(() => _hub.Clients.All.SendAsync("transferchartdata",Mediator.Send(new FetchChartDataQuery())));

            return Ok(new { Message = "Request Completed" });
        }
    }
}
