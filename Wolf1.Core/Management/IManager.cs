using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface IManager : IEmployee
    {
        List<IEmployee> ManagedEmployees { get; }
        Boolean Manage(IEmployee Target);

    }
}
