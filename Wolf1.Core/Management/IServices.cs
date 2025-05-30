﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface IServices
    {
        String Name { get; set; }
        IOffice PrimaryOffice { get; set; }
        Boolean PreCollectOnly { get; set; }
    }
}
