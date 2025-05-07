using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface IGroup 
    {
        String GroupName { get; set; }
        List<IUser> Users { get; set; }

    }
}
