using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IPostingPriority
    {
        String MonetaryFieldName { get; set; }
        int Priority { get; set; }
        Boolean SplitFees { get; set; }
        Boolean ChargeFees { get; set; }
        Boolean ReturnToClient { get; set; }
    }
}
