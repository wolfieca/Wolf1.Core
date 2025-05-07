using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Messages
{
    /// <summary>
    /// 
    /// </summary>
    public class Message : IMessage
    {
        public MessageHeader Header {get; protected set;}
        public MessageBody Body { get; protected set;}
    }
}
