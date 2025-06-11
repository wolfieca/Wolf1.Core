using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Statistics
{
    public interface IStatistics
    {
        String Month { get;}
        String Year { get; }
        Dictionary<String, int> Statistics { get; }

        Boolean Update(String StatisticName, int value);

    }

}
