﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IHistory
    {
        Dictionary<DateTime, IHistoryItem> History { get; set; }
    }
}
