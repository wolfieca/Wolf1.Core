using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Runtime;

namespace Wolf1.Core.Management
{
    interface IUser
    {
        IEmployee User { get; set; }
        String UserID { get; set; }
        String Password { get; set; }
        IRightSet Rights { get; set; }
        Boolean Active { get; set; }
        ISession ActiveSession { get; set; }

        Boolean ResetPassword();
    }
}
