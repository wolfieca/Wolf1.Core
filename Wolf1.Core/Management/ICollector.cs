using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.MessageQueues;

namespace Wolf1.Core.Management
{
    interface ICollector
    {
        String CollectorID { get; set; }
        IUser CollectorUser { get; set; }
        IOffice CollectorOffice { get; set; }
        IMessageQueue CollectorQueue { get; set; }
    }
}
