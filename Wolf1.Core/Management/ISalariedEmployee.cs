using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface ISalariedEmployee : IEmployee
    {
        int MonthlyBaseSalary { get; set; }
        Boolean OvertimeExempt { get; set; }
    }
}
