using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IChartHub
    {
        Task<List<ChartModel>> FetchChartData();
    }
}
