using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface IHistoryItem
    {
        DateTime ContactTime { get; }
        IUser User { get; }
        String Note { get; }
        Messages.IMessage Message { get; }
    }
}
