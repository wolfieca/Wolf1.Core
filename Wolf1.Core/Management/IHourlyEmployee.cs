using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IHourlyEmployee : IEmployee
    {
        int HourlyPay { get; set; }
    }
}
