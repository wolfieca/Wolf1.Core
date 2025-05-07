using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Text;
using Wolf1.Core.Document;
using Wolf1.Core.Legal;
using Wolf1.Core.Letters;
using Wolf1.Core.Management;
using Wolf1.Core.MessageQueues;
using Wolf1.Core.Reports;
using Wolf1.Core.Script;

namespace Wolf1.Core.Model
{
    public class Account : ISecurable 
    {
        public AccessControlList ACL {get; private set;}
        public AccountStatus Status {get; private set;}
        public DateTime InterestAccrualDate { get; private set;}
        public long AccountNumber {get; private set;}
        public bool IsPrimaryAccount {get; private set;}
        public Collector CurrentCollector {get; private set;}
        public Stack<Collector> PreviousCollectors {get; private set;}
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
        public bool CanCreditReport {get; private set;}
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
        public bool UpdateInterest (){
            throw new NotImplementedException();
        }
        public bool ClearInterest () {
            throw new NotImplementedException();
        }
        public bool ReinstateAccount(Account NewAccount){
            throw new NotImplementedException();
        }
        public bool MarkMailReturn(){
            throw new NotImplementedException();
        }
        public String CreditReportOutput(){
            throw new NotImplementedException();
        }
        public LetterSeries LetterSend(){
            throw new NotImplementedException();
        }
        public bool ChangeStatus(Status NewStatus){
            throw new NotImplementedException();
        }
        public bool AddLegalAction (LegalAction NewAction){
            throw new NotImplementedException();
        }
        public bool AddBankruptcy (Bankruptcy AddedBK){
            throw new NotImplementedException();
        }
    }
}
