using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IClientGroup
    {
        String GroupName { get; set; }
        IClient PrimaryClient { get; set; }
        List<IClient> Clients { get; set; }
        String ClientNameAddendum { get; set; } 
    }
}
