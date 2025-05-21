using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using Wolf1.Core.MessageQueues;
using Wolf1.Core.Messages;

namespace Wolf1.Core.Management
{
    /// <summary>
    /// The QueueManager controls the system queues. It primarily is concerned
    /// with allowing lookups of queues, helping individual queues be located
    /// for so Messages can be sent to them, and adding or removing queues as
    /// required (i.e. a new collector as added, or an old collector retires.)
    /// </summary>
    public class QueueManager
    {
        private Dictionary<String, MessageQueues.IMessageQueue> Queues;
        private SecurityManager SecurityManager;

        public Boolean Lookup(String queueName)
        {
            if (Queues.ContainsKey(queueName))
                return true;
            else
                return false;
        }
        public Boolean AddQueue(MessageQueues.IMessageQueue NewQueue)
        {
            return false;
        }
        public Boolean RetireQueue(MessageQueues.IMessageQueue RetiredQueue, MessageQueues.IMessageQueue RollToQueue)
        {
            return false;
        }
        public Boolean RetireQueue(MessageQueues.IMessageQueue RetiredQueue, MessageQueues.IMessageQueue[] RollToQueue)
        {
            return false;
        }
        public Boolean ReassignQueue(MessageQueues.IMessageQueue QueueToReassign, MessageQueues.IMessageQueue ToQueue)
        {
            return false;
        }
        public Boolean ReassignQueue(MessageQueues.IMessageQueue QueueToReasign, MessageQueues.IMessageQueue[] ToQueue)
        {
            return false;
        }
        
    }
}
