using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface ICompanyHours
    {
        Boolean IsOpen { get; set; }
        TimeOnly Start { get; set; }
        TimeOnly End { get; set; }
    }
}
