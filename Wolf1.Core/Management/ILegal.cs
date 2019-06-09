﻿using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Legal;

namespace Wolf1.Core.Management
{
    interface ILegal 
    {
        Dictionary<String, ILegalData<Object>> LegalData { get; set; }
    }
}
