using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IEmailAddress
    {
        String Address { get; set; }

        Boolean Validate();
    }
}
