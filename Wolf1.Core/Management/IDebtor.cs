using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Legal;

namespace Wolf1.Core.Management
{
    /// <summary>
    /// The IDebtor interface represents individual debtors and the operations 
    /// that they can perform
    /// </summary>
    interface IDebtor
    {
        int DebtorNumber { get;  }
        IPerson DebtorInfo { get;  }
        Decimal CurrentBalance { get; }
        Decimal OriginalBalance { get; }
        DateTime OriginalReceivedDate { get; }
        IDemographics Demographics { get;  }
        ISupplemental SupplementalData { get;  }
        IHistory History { get;  }
        IClient PrimaryClient { get;  }
        IPaymentHistory Payments { get;  }
        Dictionary<int,ILegalAction> LegalActions { get;  }
        ICollector Collector { get; }
        Dictionary<int, IDebt> Debts { get;  }
        Boolean MailReturn { get; }
        Boolean Locked { get;  }
        Boolean MergeAllowed { get; }
        Boolean SplitAllowed { get;  }

        IDebtor Merge(IDebtor DebtorToMerge);
        IDebtor Merge(IDebtor DebtorToMerge, List<IDebt> DebtsToMerge);
        IDebtor Merge(List<IDebt> DebtsToMerge);
        IDebtor Split(List<IDebt> DebtsToSplit);

        Boolean ApplyPayment(IPayment Payment);
        ICollector Reassign(ICollector NewCollector);
        ICollector Reassign(String CollectorType);

    }
}
