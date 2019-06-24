using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Document;

namespace Wolf1.Core.Management
{
    interface IAdministrator : ISalariedEmployee
    {
        IUser PoseAs(IUser newUser);
    }
}
