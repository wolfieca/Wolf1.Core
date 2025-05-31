using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface IWorkHours : ICompanyHours
    {
        TimeOnly WorkStartTime { get; set; }
        TimeOnly LunchStartTime { get; set; }
        TimeOnly LunchEndTime { get; set; }
        TimeOnly WorkEndTime { get; set; }
    }
}
