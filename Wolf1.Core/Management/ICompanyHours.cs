﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface ICompanyHours
    {
        Boolean IsOpen { get; set; }
        String Start { get; set; }
        String End { get; set; }
    }
}
