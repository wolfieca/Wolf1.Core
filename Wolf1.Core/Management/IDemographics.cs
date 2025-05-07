using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface IDemographics : ISupplemental
    {
        Dictionary<String, IDemographicData<Object>> Demographics { get; set; }
    }
}
