using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IContact : IPerson
    {
        String Title { get; set; }
        String Department { get; set; }
        String Designation { get; set; }
        Dictionary<String, IDocumentDelivery> DocumentDelivery { get; set; }
        Boolean Active { get; set; }
        Boolean Primary { get; set; }
        List<String> Notes { get; set; }
        IHistory History { get; set; }
    }
}
