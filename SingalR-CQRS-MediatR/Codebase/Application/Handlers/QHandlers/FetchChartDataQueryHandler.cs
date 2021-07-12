using API.SingalRHubConfig;
using Application.Common.Interfaces;
using Application.Queries;
using Domain.Entities;
using Infrastructure.TimerFeatures;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.QHandlers
{
    public class FetchChartDataQueryHandler : IRequestHandler<FetchChartDataQuery, List<ChartModel>>
    {
        private readonly IChartHub _iCharthub;
        private IHubContext<ChartHubConfig> _hub;
        public FetchChartDataQueryHandler(IChartHub chartHub, IHubContext<ChartHubConfig> hub) { _iCharthub = chartHub; _hub = hub; }
        public Task<List<ChartModel>> Handle(FetchChartDataQuery request, CancellationToken cancellationToken)
        {
            var timerManager = new AppTimerManager(() => _hub.Clients.All.SendAsync("transferchartdata", _iCharthub.FetchChartData()));
            // _hub.Clients.All.SendAsync("transferchartdata", _iCharthub.FetchChartData());
           return _iCharthub.FetchChartData();
        }
    }
}
