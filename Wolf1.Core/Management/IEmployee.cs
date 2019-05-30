using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IEmployee : IPerson
    {
        IOffice Office { get; set; }
        int EmployeeID { get; set; }
        
    }
}
