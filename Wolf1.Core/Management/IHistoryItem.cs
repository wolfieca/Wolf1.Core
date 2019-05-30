using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IHistoryItem
    {
        DateTime ContactTime { get; set; }
        IUser User { get; set; }
        String Note { get; set; }
        Messages.IMessage Message { get; set; }
    }
}
