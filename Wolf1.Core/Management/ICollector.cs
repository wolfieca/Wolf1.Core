using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface ICollector
    {
        String CollectorID { get; set; }
        IUser CollectorUser { get; set; }
        IOffice CollectorOffice { get; set; }

    }
}
