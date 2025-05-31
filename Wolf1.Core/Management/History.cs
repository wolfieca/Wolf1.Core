using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public class History : IHistory
    {
        public Dictionary<DateTime, HistoryItem> Contacts { get; }
    }
}
