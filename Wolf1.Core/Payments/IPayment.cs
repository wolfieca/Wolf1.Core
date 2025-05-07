using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Legal;
using Wolf1.Core.Management;

namespace Wolf1.Core
{
    public interface IPayment
    {
        IDebtor Debtor { get; }
        IDebt Debt { get;  }
        Decimal PaymentAmount { get;  }
        Decimal WriteOff { get; }
        Decimal RemainingBalance { get; }
        Decimal Fee { get; }
        Decimal ClientBase { get; }
        IFeeSchedule FeeSchedule { get; }
        ILegalAction Action { get; }
        Dictionary<String, Decimal> BreakDown { get; }
        Boolean Reversal { get; }
        Boolean ReversalReason { get; }
        IPayment ReversalMatch { get; }
        IBatchType BatchType { get; }
        String Reason { get; }
        DateTime Added { get; }
        DateTime Paid { get;  }

        Boolean Post();

    }
}
