using API.SingalRHubConfig;
using Application.Queries;
using Infrastructure.TimerFeatures;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
