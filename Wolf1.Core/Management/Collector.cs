using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Document;
using Wolf1.Core.MessageQueues;
using Wolf1.Core.Script;
using Wolf1.Core.Statistics;
using Wolf1.Core.System;

namespace Wolf1.Core.Management
{
    public class Collector : ICollector
    {
        /*public Collector()
        {
        }*/

        public string CollectorID {get; }
        public IPersonName Alias {get; }
        public List<IOffice> CollectionOffices {get; }
        public List<string> Specialty {get; }
        public IMessageQueue CollectorQueue {get; }
        public Money HighBalance {get; }
        public Money LowBalance {get; }
        public IStatistics Statistics {get; }
        public bool AutoReassignOldAccounts {get; }
        public int MonthsBeforeAutoReassigb {get; }
        public int StrategyWaitDays {get; }

        public Money MonthlyQuotaHigh => throw new NotImplementedException();

        public DateTime MonthlyQuotaHighDate => throw new NotImplementedException();

        public Money MonthlyQuotaLow => throw new NotImplementedException();

        public DateTime MonthlyQuotaLowDate => throw new NotImplementedException();

        public Money MonthlyQuotaPromised => throw new NotImplementedException();

        public Money CurrentAmountCollected => throw new NotImplementedException();

        public Money CurrentAmountPromised => throw new NotImplementedException();

        public int MaxQueueSize => throw new NotImplementedException();

        public int MaxNewbizSize => throw new NotImplementedException();

        public string GroupName {get; }
        public string Team {get; }
        public int MaxQueueTotalSize {get; }
        public IScript CollectorScript {get; }
        public int HourlyPay {get; }
        public IOffice Office {get; }
        public int EmployeeID {get; }
        public IUser SystemUser {get; }
        public Dictionary<string, IDocument> OnboardingDocuments {get; }
        public Dictionary<string, IWorkHours> DefaultWorkSchedule {get; }
        public DateTime StartDate {get; }
        public DateTime TerminationDate {get; }
        public IEmployee Supervisor {get; }
        public IPhoneNumber WorkPhone {get; }
        public IEmailAddress WorkEmailAddress {get; }
        public bool Fulltime {get; }
        public History History {get; }
        public IPersonName Name {get; }
        public IAddress Address {get; }
        public IEmailAddress Email {get; }
        public Dictionary<string, IPhoneNumber> PhoneNumbers {get; }
        public List<IDebtor> AssignedDebtors {get; }
        public IAddress CompanyAddress {get; }
        public ICompany Parent {get; }
        public IClassOfBusiness BusinessClass {get; }
        public DateTime AddDate {get; }
        public IUser AddUser {get; }
        public DateTime UpdateDate {get; }
        public IUser UpdateUser {get; }
        public Dictionary<string, IPhoneNumber> PhoneNumber {get; }
        public Dictionary<string, ICompanyHours> Hours {get; }
        public bool AllowMarketingMaterials {get; }
        public IAddress PhysicalAddress {get; }
        public IAddress MailingAddress {get; }
        public List<IContact> Contacts {get; }
        public IMessageQueue CompanyQueue {get; }
        public List<string> Notes {get; }
        public bool Client {get; }
        public bool Lead {get; }
        public bool Active {get; }
        public bool Inactive {get; }
        public bool Dead {get; }
        public DateTime ChangedToClient {get; }
        public DateTime ChangedToLead {get; }
        public DateTime ChangedToActive {get; }
        public DateTime ChangedToInactive {get; }
        public DateTime ChangedToDead {get; }

        public bool CanBeRehired => throw new NotImplementedException();

        string ICompany.Name {get; }
        IHistory ICompany.History {get; }

        public bool Assign(IDebtor DebtorToAssign)
        {
            throw new NotImplementedException();
        }

        public bool Recall(IDebtor DebtorToAssign)
        {
            throw new NotImplementedException();
        }
    }
}
