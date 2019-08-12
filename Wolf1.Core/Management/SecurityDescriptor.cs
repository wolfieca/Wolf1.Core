using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Wolf1.Core.Management
{
    class SecurityDescriptor
    {
        IUser Owner { get; set; }
        //IGroup PrimaryGroup { get; set; }
        AccessControlList ACL { get; set; }

        protected SecurityDescriptor(IUser user, String AuthenticationFactor, IPAddress SourceIP)
        {
            
        }
    }
}
