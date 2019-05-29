using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface ICompany
    {
        String CompanyName { get; set; }
        IAddress CompanyAddress { get; set; }
        
    }
}
