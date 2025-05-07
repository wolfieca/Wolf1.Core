using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface ISocialSecurityNumber
    {
        String AreaNumber { get; set; }
        String GroupNumber { get; set; }
        String SerialNumber { get; set; }

        String TraditionalFormat();
        String FlatFormat();
        Boolean Validate();
    }
}
