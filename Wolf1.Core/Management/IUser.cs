using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Wolf1.Core.Runtime;

namespace Wolf1.Core.Management
{
    public interface IUser
    {
        IEmployee User { get; set; }
        String UserID { get; set; }
        String Password { get; set; }
        IRightSet Rights { get; set; }
        Boolean Active { get; set; }
        ISession ActiveSession { get; set; }
        IGroup PrimaryGroup { get; set; }
        List<IGroup> Groups { get; set; }

        Boolean ResetPassword();
        SecurityDescriptor Authenticate(String SecurityFactor, DateTime LoginTime, IPAddress LoginIPAddress);
    }
}
