using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IDemographicData<Object> : ISupplementalData<Object>
    {
        Boolean PHI { get; set; }
    }
}
