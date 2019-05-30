using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IDateOfBirth
    {
        DateTime DOB { get; set; }

        int Age();
    }
}
