using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IPaymentBatch
    {
        int BatchMonth { get; }
        IOffice BatchOffice { get; }
        int BatchNumber { get; }
        String BatchID { get; }
        IBatchType BatchType { get; }
        int BatchTransactionsEntered { get; }
        Decimal BatchDollars { get; }
        List<IPayment> Payments { get;  }
        int NumberOfPayments { get; }
        Decimal AssertedBatchDollars { get; }
        int AssertedNumberOfPayments { get; }
        DateTime BatchDate { get; }
        Boolean Balanced { get; }
        Boolean Held { get; }
        Boolean Corrupt { get; }
        Boolean Done { get; }
        Boolean Batch { get; }
        Boolean Acknowledge { get; }
        Boolean Delete { get; }
        Boolean FromConversion { get; }

        Decimal TotalBreakdown(String SubPart);
    }
}
