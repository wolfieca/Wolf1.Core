using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface ITime
    {
        int Hour { get; set; }
        int Minute { get; set; }
        Boolean AM { get; set; }
        String Time();
    }
}
