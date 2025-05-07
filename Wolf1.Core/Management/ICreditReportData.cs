using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface ICreditReportData
    {
        DateTime OriginalReport { get; set; }
        IDebtStatus DebtStatus { get; set; }
        Boolean DebtIsDisputed { get; set; }
        Boolean DebtISValid { get; set; }

    }
}
