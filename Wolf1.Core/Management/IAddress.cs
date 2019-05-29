using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IAddress
    {
        String StreetAddress { get; set; }
        String POBox { get; set; }
        String Attention { get; set; }
        String City { get; set; }
        String State { get; set; }
        String Zip { get; set; }
    }
}
