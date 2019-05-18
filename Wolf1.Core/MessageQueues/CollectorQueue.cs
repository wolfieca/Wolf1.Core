using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.MessageQueues
{
    /// <summary>
    /// A CollectorQueue is a semi=priority Queue. Internally, it is made up
    /// of several queues holding messages of specific priorities. The individual
    /// queue objects are basically transient and only exist while there are
    /// still messages waiting in the queue. The main queue is persistent,
    /// and can be queried or acted upon whether it's empty or not.
    /// </summary>
    class CollectorQueue : MessageQueue
    {
    }
}
