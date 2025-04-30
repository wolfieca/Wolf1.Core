using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Text;
using Wolf1.Core.Document;
using Wolf1.Core.Legal;
using Wolf1.Core.Management;
using Wolf1.Core.MessageQueues;
using Wolf1.Core.Reports;
using Wolf1.Core.Script;

namespace Wolf1.Core.Model
{
    class Account : ISecurable 
    {
        public AccessControlList ACL {get; private set;}
        public AccountStatus Status {get; private set;}
        public DateTime InterestAccrualDate { get; private set;}
        public long AccountNumber {get; private set;}
        public bool IsPrimaryAccount {get; private set;}
        public Collector CurrentCollector {get; private set;}
        public Queue<Collector> PreviousCollectors {get; private set;}
        public Person Guarantor {get; private set;}
        public Person OtherGuarantor {get; private set;}
        public Person Patient { get; private set; }
        public MessageQueue AccountQueue {get; private set; }
        public Office AccountOffice { get; private set; }
        public Client AccountClient {get; private set; }
        public FeeSchedule ClientFeeSchedule { get; private set; }
        public Client PrimaryClient { get; private set;}
        public bool IsMailReturn {get; private set; }
        public bool EverMailReturn { get; private set; }
        public bool IsPaidInFull { get; private set; }
        public bool WorkedSinceNewBusiness { get; private set;}
        public bool HasAssets { get; private set;}
        public bool HasEmployerInfo { get; private set;}
        public bool HasAddressInfo { get; private set;}
        public bool HasPhoneNumber {get; private set;}
        public bool WithAttorney { get; private set;}
        public bool WithForwarder {get; private set;}
        public bool DoNotCallAtAll { get; private set;}
        public bool DoNotCallHome { get; private set; }
        public bool DoNotCallWork { get; private set;}
        public bool DoNotWriteWork {get; private set; }
        public bool ADebtHasBeenReturned { get; private set; }
        public bool HasEverSentNSFCheck {get; private set;}
        public bool EverSkipTracedPhone { get; private set;}
        public bool EverSkipTracedAddress {get; private set;}
        public bool EverSkipTracedReserved { get; private set;}
        public bool IsPrecollectAccount { get; private set; }
        public bool IsMergeInProgress {get; private set; }
        public bool IsSplitInProgress {get; private set;}
        public Strategy AccountStrategy {get; private set;}
        public Priority AccountPriority { get; private set;}
        public Contractor AttorneyForwarderSentTo { get; private set; }
        public DateTime DateSentOut { get; private set;}
        public DateTime DateLastSeen {get; private set;}
        public DateTime DateLastNewBusiness { get; private set; }

        public Dictionary<string, Decimal> Owed {get; private set;}
        public Dictionary<string, Decimal> Paid {get; private set;}
        public Dictionary<string, Decimal> Adjusted {get; private set;}
        public Dictionary<string, Decimal> Original {get; private set;}
        public Dictionary<string, Boolean> AccruesInterest {get; private set;}
        public Dictionary<string, Decimal> Interest {get; private set;}

        public Dictionary<string, Decimal> TotalOwed {get; private set;}
        public Dictionary<string, Decimal> TotalPaid {get; private set; }
        public Dictionary<string, Decimal> TotalAdjusted {get; private set; }
        public Dictionary<string, Decimal> TotalOriginal {get; private set; }
        public Dictionary<string, Decimal> TotalInterest {get; private set;}

        public Boolean AccrueInterest { get; private set;}
        public DateTime LastInterestDate { get; private set;}
        public DateTime ReceivedDate {get; private set; }
        public DateTime LastPaidDate {get; private set;}
        public DateTime LastServiceDate {get; private set;}

        public Demographics AccountDemographics {get; private set;}
        public List<Account> LinkedAccounts {get; private set;}
        public History Contacts {get; private set;}
        public Dictionary<DateTime, Payment> PaymentHistory {get; private set;}
        public List<LegalAction> LegalActions {get; private set;}
        public List<Report> Reports {get; private set;}
        public List<Metro2CreditReport> CreditReports { get; private set;}
        public List<IDocument> Documents {get; private set;}

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

        public IDebtor[] Merge(IDebtor DebtorToMerge)
        {
            throw new NotImplementedException();
        }

        public IDebtor[] Merge(IDebtor DebtorToMerge, List<IDebt> DebtsToMerge)
        {
            throw new NotImplementedException();
        }

        public IDebtor[] Merge(List<IDebt> DebtsToMerge)
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

        public IDebtor[] Split(List<IDebt> DebtsToSplit)
        {
            throw new NotImplementedException();
        }
    }
}
