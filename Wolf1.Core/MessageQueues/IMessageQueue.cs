using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Management;

namespace Wolf1.Core.MessageQueues
{
    /// <summary>
    /// Classes implementing IMessageQueue interface are responsible for
    /// routing messages throughout the system. They don't actually process
    /// the messages, they just send them where they belong.
    /// </summary>
    public interface IMessageQueue
    {
        String QueueName { get; set; }
        String QueueDescription { get; set; }
        QueueManager LocalQueueManager { get; }
        SecurityManager SecurityManager { get;  }
        bool Send(IMessageQueue recipient, Messages.IMessage theMessage);
        bool Receive(IMessageQueue sender, Messages.IMessage acceptMessage);
        bool Reject(IMessageQueue sender, Messages.IMessage rejectMessage);
        Messages.IMessage Next();
    }
}
