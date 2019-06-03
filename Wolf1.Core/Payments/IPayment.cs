using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Management;

namespace Wolf1.Core
{
    interface IPayment
    {
        IDebtor Debtor { get; set; }
        IDebt Debt { get; set; }
        int PaymentAmount { get; set; }
        int WriteOff { get; set; }
        int RemainingBalance { get; set; }
        String Reason { get; set; }
        DateTime Added { get; set; }
        DateTime Paid { get; set; }

        Boolean Post();
    }
}
