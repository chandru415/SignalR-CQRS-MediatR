using Application.Common.Interfaces;
using Domain.Entities;
using Infrastructure.TimerFeatures;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class ChartHubService : IChartHub
    {
        public Task<List<ChartModel>> FetchChartData()
        {

            var r = new Random();
            return Task.FromResult(new List<ChartModel>()
            {
                new ChartModel { Data = new List<int> { r.Next(1, 40) }, Label = "Data1" },
                new ChartModel { Data = new List<int> { r.Next(1, 40) }, Label = "Data2" },
                new ChartModel { Data = new List<int> { r.Next(1, 40) }, Label = "Data3" },
                new ChartModel { Data = new List<int> { r.Next(1, 40) }, Label = "Data4" }
            });
        }
    }
}
