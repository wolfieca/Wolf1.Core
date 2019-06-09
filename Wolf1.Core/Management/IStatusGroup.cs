﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IStatusGroup
    {
        String Name { get; set; }
        List<IStatus> Members { get; set; }
    }
}
