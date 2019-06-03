using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface ISupplementalData<T>
    {
        T DataField { get; set; }
    }
}
