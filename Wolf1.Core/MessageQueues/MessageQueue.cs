using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Management;
using Wolf1.Core.MessageQueues;
using Wolf1.Core.Messages;

namespace Wolf1.Core.MessageQueues

{
    /// <summary>
    /// A MessageQueue is a generic MessageQueue.
    /// MessageQueue objects are responsible to sending/receiving Messages
    /// between parts of the system
    /// </summary>
    class MessageQueue : IMessageQueue
    {
        public string QueueName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public SecurityManager SecurityManager => throw new NotImplementedException();

        public QueueManager LocalQueueManager => throw new NotImplementedException();

        public string QueueDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IMessage Next()
        {
            throw new NotImplementedException();
        }

        public bool Receive(IMessageQueue sender, IMessage theMessage)
        {
            throw new NotImplementedException();
        }

        public bool Reject(IMessageQueue sender, IMessage theMessage)
        {
            throw new NotImplementedException();
        }

        public bool Send(IMessageQueue recipient, IMessage theMessage)
        {
            throw new NotImplementedException();
        }
    }
}
