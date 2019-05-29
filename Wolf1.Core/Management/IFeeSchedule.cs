using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IFeeSchedule
    {
        String FeeScheduleID { get; set; }
        String FeeScheduleName { get; set; }
        int ForwarderPercentage { get; set; }
        int AttorneyPercentage { get; set; }
        int MailReturnPercentage { get; set; }
        int OldAccountPercentage { get; set; }
        int OldAccountAge { get; set; }
        int InterestRate { get; set; }
        Boolean InterestPriorToReceipt { get; set; }
        Boolean UseAttorney { get; set; }
        Boolean Commercial { get; set; }
        Boolean CompoundInterest { get; set; }
        int CollectionChargePercentage { get; set; }
        int CollectionChargeFlat { get; set; }
        int CollectionChargeMaxDollarBase { get; set; }
        int NoLetterReturnToClientMin { get; set; }
        int SalesTax { get; set; }
        IPostingPriority[] PostingPriorities { get; set; }
        int NoFeeDays { get; set; }
        ITier[] Tiers { get; set; }
        int ReturnDates { get; set; }
    }
}
