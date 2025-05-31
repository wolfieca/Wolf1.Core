using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Messages;

namespace Wolf1.Core.Management
{
    public class HistoryItem : IHistoryItem
    {
        public DateTime ContactTime { get; }
        public IUser User { get; }
        public string Note { get; }
        public IMessage Message { get; }
    }
}
