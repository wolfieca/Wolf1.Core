using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface IHistory
    {
        Dictionary<DateTime, IHistoryItem> History { get; set; }
    }
}
