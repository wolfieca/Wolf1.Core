using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    /// <summary>
    /// The IDebtor interface represents individual debtors and the operations 
    /// that they can perform
    /// </summary>
    interface IDebtor
    {
        int DebtorNumber { get; set; }
        String LastName { get; set; }
        String FirstName { get; set; }
        String Suffix { get; set; }
        String Title { get; set; }
        Decimal CurrentBalance { get; set;}
        Decimal OriginalBalance { get; set; }
        IDemographics Demographics { get; set; }
        IHistory History { get; set; }
        IClient PrimaryClient { get; set; }
        IPayment Payments { get; set; }
        Legal.ILegalAction LegalActions { get; set; }
        ICollector Collector { get; set; }
    }
}
