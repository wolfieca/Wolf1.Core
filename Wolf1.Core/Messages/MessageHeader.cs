using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.MessageQueues;

namespace Wolf1.Core.Messages
{
    /// <summary>
    /// 
    /// </summary>
    public class MessageHeader 
    {
        public MessageQueue Sender { get; private set;}
        public DateTime Created { get; private set;}
        public MessageQueue Recipient { get; private set;}
        public DateTime Sent { get; private set;}
        public DateTime Received {get; private set;}
        public Boolean Accepted {get; private set;}
        public DateTime AcceptRejectTime {get; private set;}
        public String Subject {get; private set; }
    }
}
