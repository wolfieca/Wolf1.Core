using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IPerson
    {
        IPersonName Name { get; set; }
        IAddress Address { get; set; }
        IEmailAddress Email { get; set; }
        Dictionary<String,IPhoneNumber> PhoneNumbers { get; set; }
    }
}
