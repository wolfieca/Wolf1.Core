using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Document;

namespace Wolf1.Core.Management
{
    interface ISupervisor : ISalariedEmployee
    {
        List<IEmployee> SupervisedEmployees { get; }
        Boolean Supervise(IEmployee Target);
    }
}
