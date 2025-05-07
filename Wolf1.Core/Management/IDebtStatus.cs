using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface IDebtStatus
    {
        Boolean Ignore { get; set; }
        Boolean Submit { get; set; }
        Boolean Reported { get; set; }
        Boolean Update { get; set; }
        Boolean PaidInFull { get; set; }
        Boolean Withdraw { get; set; }
        Boolean ReportedPaidInFull { get; set; }
        Boolean Closed { get; set; }
        Boolean Reject { get; set; }

        String Status();
        void Status(String status);
    }
}
