using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface IHourlyEmployee : IEmployee
    {
        int HourlyPay { get;  }
    }
}
