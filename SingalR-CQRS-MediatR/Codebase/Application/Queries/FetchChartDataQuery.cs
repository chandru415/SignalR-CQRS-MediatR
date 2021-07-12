using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries
{
    public class FetchChartDataQuery: IRequest<List<ChartModel>>
    {
    }
}
