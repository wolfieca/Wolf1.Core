using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface IWorkHours : ICompanyHours
    {
        DateTime WorkStartTime { get; set; }
        DateTime LunchStartTime { get; set; }
        DateTime LunchEndTime { get; set; }
        DateTime WorkEndTime { get; set; }
    }
}
