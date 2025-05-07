using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Document;
using Wolf1.Core.MessageQueues;
using Wolf1.Core.Script;
using Wolf1.Core.Statistics;

namespace Wolf1.Core.Management
{
    public class Collector : ICollector
    {
        public string CollectorID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IPersonName Alias { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IOffice> CollectionOffices { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> Specialty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IMessageQueue CollectorQueue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal HighBalance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal LowBalance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IStatistics Statistics { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AutoReassignOldAccounts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MonthsBeforeAutoReassigb { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int StrategyWaitDays { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public decimal MonthlyQuotaHigh => throw new NotImplementedException();

        public DateTime MonthlyQuotaHighDate => throw new NotImplementedException();

        public decimal MonthlyQuotaLow => throw new NotImplementedException();

        public DateTime MonthlyQuotaLowDate => throw new NotImplementedException();

        public decimal MonthlyQuotaPromised => throw new NotImplementedException();

        public decimal CurrentAmountCollected => throw new NotImplementedException();

        public decimal CurrentAmountPromised => throw new NotImplementedException();

        public int MaxQueueSize => throw new NotImplementedException();

        public int MaxNewbizSize => throw new NotImplementedException();

        public string GroupName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Team { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MaxQueueTotalSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IScript CollectorScript { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int HourlyPay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IOffice Office { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int EmployeeID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IUser SystemUser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Dictionary<string, IDocument> OnboardingDocuments { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Dictionary<string, IWorkHours> DefaultWorkSchedule { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime StartDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime TerminationDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEmployee Supervisor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IPhoneNumber WorkPhone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEmailAddress WorkEmailAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Fulltime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public History History { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IPersonName Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IAddress Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEmailAddress Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Dictionary<string, IPhoneNumber> PhoneNumbers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IDebtor> AssignedDebtors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IAddress CompanyAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ICompany Parent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IClassOfBusiness BusinessClass { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime AddDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IUser AddUser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime UpdateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IUser UpdateUser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Dictionary<string, IPhoneNumber> PhoneNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Dictionary<string, ICompanyHours> Hours { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AllowMarketingMaterials { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IAddress PhysicalAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IAddress MailingAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IContact> Contacts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IMessageQueue CompanyQueue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> Notes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Client { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Lead { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Active { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Inactive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Dead { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ChangedToClient { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ChangedToLead { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ChangedToActive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ChangedToInactive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ChangedToDead { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ICompany.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IHistory ICompany.History { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
