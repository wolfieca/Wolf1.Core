using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface ITier
    {
        String FeeBase { get; set; }
        Int64 TierLimit { get; set; }
        int AgencyPercent { get; set; }
        int AgencyMinimumFee { get; set; }
        int AgencyMaximumFee { get; set; }
    }
}
