using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Statistics
{
    interface IStatistics
    {
        String Month { get; set; }
        String Year { get; set; }
        Dictionary<String, int> Statistics { get; set; }

        Boolean Update(String StatisticName, int value);

    }
}
