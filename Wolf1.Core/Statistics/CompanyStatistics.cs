using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Statistics
{
    public class CompanyStatistics : IStatistics
    {
        public string Month { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Year { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Dictionary<string, int> Statistics { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Update(string StatisticName, int value)
        {
            throw new NotImplementedException();
        }
    }
}
