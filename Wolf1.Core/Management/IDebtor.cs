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
        int DebtorNumber { get; set; }
        Decimal CurrentBalance { get; set;}
        Decimal OriginalBalance { get; set; }
        IDemographics Demographics { get; set; }
        IHistory History { get; set; }
        IClient PrimaryClient { get; set; }
        IPayment Payments { get; set; }
        ILegalAction LegalActions { get; set; }
        ICollector Collector { get; set; }

        IDebtor Merge(IDebtor DebtorToMerge);
        IDebtor Merge(IDebtor DebtorToMerge, List<IDebt> DebtsToMerge);
        IDebtor Merge(List<IDebt> DebtsToMerge);
        IDebtor Split(List<IDebt> DebtsToSplit);
        
    }
}
