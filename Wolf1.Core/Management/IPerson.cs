using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface IPerson
    {
        IPersonName Name { get; }
        IAddress Address { get; }
        IEmailAddress Email { get; }
        Dictionary<String,IPhoneNumber> PhoneNumbers { get; }
    }
}
