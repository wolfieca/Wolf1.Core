using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IDemographics : ISupplemental
    {
        Dictionary<String, IDemographicData<Object>> Demographics { get; set; }
    }
}
