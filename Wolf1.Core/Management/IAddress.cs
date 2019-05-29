using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IAddress
    {
        IAddress StreetAddress { get; set; }
        String POBox { get; set; }
        IPersonName Attention { get; set; }
        String City { get; set; }
        IState State { get; set; }
        IZipCode Zip { get; set; }
    }
}
