using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IServices
    {
        String Name { get; set; }
        IOffice Primary { get; set; }
    }
}
