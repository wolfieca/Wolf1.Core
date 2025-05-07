using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Wolf1.Core.Management;
using Wolf1.Core.MessageQueues;

namespace Wolf1.Core.Runtime
{
    public interface ISession
    {
        IUser SessionOwner { get; set; }
        DateTime Start { get; set; }
        IPAddress MachineAddress { get; set; }
        IMessageQueue SessionQueue { get; set; }

        ISession CreateSession(IUser Owner);
        
    }
}
