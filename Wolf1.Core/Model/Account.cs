using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Resources;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Wolf1.Core.Document;
using Wolf1.Core.Legal;
using Wolf1.Core.Letters;
using Wolf1.Core.Management;
using Wolf1.Core.MessageQueues;
using Wolf1.Core.Messages;
using Wolf1.Core.Reports;
using Wolf1.Core.Script;

namespace Wolf1.Core.Model
{

    public enum MoneyTypes { Principal, CollectionCharge, Interest, CourtCosts, LegalFees, AttorneyFees };
    public class Account : ISecurable
    {
        public AccessControlList ACL { get; private set; }
        public AccountStatus Status { get; private set; }
        public DateTime InterestAccrualDate { get; private set; }
        public long AccountNumber { get; private set; }
        public bool IsPrimaryAccount { get; private set; }
        public Collector CurrentCollector { get; private set; }
        public Stack<Collector> PreviousCollectors { get; private set; }
        public Person Guarantor { get; private set; }
        public Person OtherGuarantor { get; private set; }
        public Person Patient { get; private set; }
        public MessageQueue AccountQueue { get; private set; }
        public Office AccountOffice { get; private set; }
        public Client AccountClient { get; private set; }
        public FeeSchedule ClientFeeSchedule { get; private set; }
        public Client PrimaryClient { get; private set; }
        public bool IsMailReturn { get; private set; } = false;
        public bool EverMailReturn { get; private set; } = false;
        public bool IsPaidInFull { get; private set; } = false;
        public bool WorkedSinceNewBusiness { get; private set; } = false;
        public bool HasAssets { get; private set; } = false;
        public bool HasEmployerInfo { get; private set; } = false;
        public bool HasAddressInfo { get; private set; } = false;
        public bool HasPhoneNumber { get; private set; } = false;
        public bool WithAttorney { get; private set; } = false;
        public bool WithForwarder { get; private set; } = false;
        public bool DoNotCallAtAll { get; private set; } = false;
        public bool DoNotCallHome { get; private set; } = false;
        public bool DoNotCallWork { get; private set; } = false;
        public bool DoNotWriteWork { get; private set; } = false;
        public bool ADebtHasBeenReturned { get; private set; } = false;
        public bool HasEverSentNSFCheck { get; private set; } = false;
        public bool EverSkipTracedPhone { get; private set; } = false;
        public bool EverSkipTracedAddress { get; private set; } = false;
        public bool EverSkipTracedReserved { get; private set; } = false;
        //public bool IsPrecollectAccount { get; private set; }
        public bool IsMergeInProgress { get; private set; } = false;
        //public bool IsSplitInProgress {get; private set;}
        public bool CanCreditReport { get; private set; } = false;
        public Strategy AccountStrategy { get; private set; }
        public Priority AccountPriority { get; private set; }
        public Contractor AttorneyForwarderSentTo { get; private set; }
        public DateTime DateSentOut { get; private set; }
        public DateTime DateLastSeen { get; private set; }
        public DateTime DateLastNewBusiness { get; private set; }
        public Dictionary<MoneyTypes, Decimal> Owed { get; private set; }
        public Dictionary<MoneyTypes, Decimal> Paid { get; private set; }
        public Dictionary<MoneyTypes, Decimal> Adjusted { get; private set; }
        public Dictionary<MoneyTypes, Decimal> Original { get; private set; }
        public Dictionary<MoneyTypes, Boolean> AccruesInterest { get; private set; }
        public Dictionary<MoneyTypes, Decimal> Interest { get; private set; }
        public Dictionary<MoneyTypes, Decimal> TotalOwed { get; private set; }
        public Dictionary<MoneyTypes, Decimal> TotalPaid { get; private set; }
        public Dictionary<MoneyTypes, Decimal> TotalAdjusted { get; private set; }
        public Dictionary<MoneyTypes, Decimal> TotalOriginal { get; private set; }
        public Dictionary<MoneyTypes, Decimal> TotalInterest { get; private set; }

        public Boolean AccrueInterest { get; private set; } = true;
        public DateTime LastInterestDate { get; private set; }
        public DateTime ReceivedDate { get; private set; }
        public DateTime LastPaidDate { get; private set; }
        public DateTime LastServiceDate { get; private set; }

        public Demographics AccountDemographics { get; private set; }
        public List<Account> LinkedAccounts { get; private set; }
        public History Contacts { get; private set; }
        public Dictionary<DateTime, Payment> PaymentHistory { get; private set; }
        public List<LegalAction> LegalActions { get; private set; }
        public List<Report> Reports { get; private set; }
        public List<Metro2CreditReport> CreditReports { get; private set; }
        public List<IDocument> Documents { get; private set; }
        public bool ApplyPayment(IPayment Payment)
        {
            throw new NotImplementedException();
        }
        public IAssignee Assign(IAssignee AssignTo)
        {
            throw new NotImplementedException();
        }
        public bool ChangeStrategy(IStrategy NewStrategy)
        {
            throw new NotImplementedException();
        }
        public Account[] Merge(Account AccountToMerge)
        {
            throw new NotImplementedException();
        }
        public Account[] Merge(List<Account> AccountsToMerge)
        {
            throw new NotImplementedException();
        }
        public ICollector Reassign(ICollector NewCollector)
        {
            throw new NotImplementedException();
        }
        public ICollector Reassign(string CollectorType)
        {
            throw new NotImplementedException();
        }
        public Account[] Split(List<Account> AccountsToSplit)
        {
            throw new NotImplementedException();
        }
        public Account FindPrimaryAccount()
        {
            throw new NotImplementedException();
        }
        public bool UpdateInterest()
        {
            throw new NotImplementedException();
        }
        public bool ClearInterest()
        {
            throw new NotImplementedException();
        }
        public Account ReinstateAccount(Account NewAccount)
        {
            throw new NotImplementedException();
        }
        public bool MarkMailReturn()
        {
            throw new NotImplementedException();
        }
        public String CreditReportOutput()
        {
            throw new NotImplementedException();
        }
        public LetterSeries LetterSend()
        {
            throw new NotImplementedException();
        }
        public bool ChangeStatus(Status NewStatus)
        {
            throw new NotImplementedException();
        }
        public bool AddLegalAction(LegalAction NewAction)
        {
            throw new NotImplementedException();
        }
        public bool AddBankruptcy(Bankruptcy AddedBK)
        {
            throw new NotImplementedException();
        }
        public bool SendToAttorney(Attorney receivingAttorney)
        {
            throw new NotImplementedException();
        }
        public bool ForwardAccount(Forwarder forwarder)
        {
            throw new NotImplementedException();
        }
        public bool RetrieveAccount(Account forwardedAccount)
        {
            throw new NotImplementedException();
        }
        public bool FreezeInterest(DateTime freezeUntil)
        {
            throw new NotImplementedException();
        }
        public bool FreezeInterest()
        {
            throw new NotImplementedException();
        }
        public bool UnfreezeInterest()
        {
            throw new NotImplementedException();
        }
        public Metro2Record[] ToMetro2Record()
        {
            throw new NotImplementedException();
        }
        public CreditReportRequest MakeCreditReportRequest()
        {
            throw new NotImplementedException();
        }
    }
}
