using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Management;

namespace Wolf1.Core.Accounting
{
    interface IEquipment : IAsset
    {
        IEmployee AssignedTo { get; set; }

    }
}
