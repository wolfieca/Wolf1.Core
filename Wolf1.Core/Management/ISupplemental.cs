using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface ISupplemental
    {
        Dictionary<String, ISupplementalData<Object>> SupplementalData { get; set; }
    }
}
