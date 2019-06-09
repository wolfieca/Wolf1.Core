using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface IDebt
    {
        String Account { get; set; }
        IPerson ForWhom { get; set; }
        IClient Client { get; set; }
        IFeeSchedule FeeSchedule { get; set; }
        Boolean EverMailReturn { get; set; }
        Boolean Locked { get; set; }
        Boolean AccrueInterest { get; set; }
        DateTime ReceivedDate { get; set; }
        DateTime DateOfLastPayment { get; set; }
        DateTime ClientDateOfLastCharge { get; set; }
        DateTime ClientDateOfLastPayment { get; set; }
        DateTime LastInterest { get; set; }
        Dictionary<String, int> Owed { get; set; }
        Dictionary<String, int> Paid { get; set; }
        int OriginalBalance { get; set; }
        int AttorneyFee { get; set; }
        int AgencyFee { get; set; }
        int TotalPaid { get; set; }
        int CurrentBalance { get; set; }
        IPaymentHistory Payments { get; set; }
        IState PlacementState { get; set; }
        List<String> Comments { get; set; }
        IHistory History { get; set; }

        Boolean UpdateInterest();
        Boolean ApplyPayment(IPayment Payment);
    }
}
