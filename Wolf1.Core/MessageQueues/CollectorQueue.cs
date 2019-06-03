using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Management;
using Wolf1.Core.Messages;

namespace Wolf1.Core.MessageQueues
{
    /// <summary>
    /// A CollectorQueue is a semi=priority Queue. Internally, it is made up
    /// of several queues holding messages of specific priorities. The individual
    /// queue objects are basically transient and only exist while there are
    /// still messages waiting in the queue. The main queue is persistent,
    /// and can be queried or acted upon whether it's empty or not.
    /// </summary>
    class CollectorQueue : IMessageQueue
    {
        public string QueueName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string QueueDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public QueueManager LocalQueueManager => throw new NotImplementedException();

        public SecurityManager SecurityManager => throw new NotImplementedException();

        public IMessage Next()
        {
            throw new NotImplementedException();
        }

        public bool Receive(IMessageQueue sender, IMessage acceptMessage)
        {
            throw new NotImplementedException();
        }

        public bool Reject(IMessageQueue sender, IMessage rejectMessage)
        {
            throw new NotImplementedException();
        }

        public bool Send(IMessageQueue recipient, IMessage theMessage)
        {
            throw new NotImplementedException();
        }
    }
}
