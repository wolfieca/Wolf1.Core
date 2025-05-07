using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface IWorkHours : ICompanyHours
    {
        ITime WorkStartTime { get; set; }
        ITime LunchStartTime { get; set; }
        ITime LunchEndTime { get; set; }
        ITime WorkEndTime { get; set; }
    }
}
