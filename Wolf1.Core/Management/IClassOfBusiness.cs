using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IClassOfBusiness
    {
        int BusinessClassID { get; set; }
        String Description { get; set; }
        Boolean DebtsCreditReportable { get; set; }
        List<IServices> AllowedServices { get; set; }

    }
}
