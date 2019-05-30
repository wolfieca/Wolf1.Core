using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IOffice
    {
        String Name { get; set; }
        IAddress Address { get; set; }
        List<IServices> Services { get; set; }
    }
}
