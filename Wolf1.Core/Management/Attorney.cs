using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.MessageQueues;

namespace Wolf1.Core.Management
{
    public class Attorney : IAssignee
    {
        public string Name { get ; set; }
        public IAddress CompanyAddress {  get ; set;  }
        public ICompany Parent {  get ; set;  }
        public IClassOfBusiness BusinessClass {  get ; set; }
        public DateTime AddDate {  get ; set; }
        public IUser AddUser { get ; set ; }
        public DateTime UpdateDate { get ; set ; }
        public IUser UpdateUser { get ; set ; }
        public Dictionary<string, IPhoneNumber> PhoneNumber { get ; set ; }
        public Dictionary<string, ICompanyHours> Hours { get ; set ; }
        public bool AllowMarketingMaterials { get ; set ; }
        public IAddress PhysicalAddress { get ; set ; }
        public IAddress MailingAddress { get ; set ; }
        public List<IContact> Contacts { get ; set ; }
        public IHistory History { get ; set ; }
        public IMessageQueue CompanyQueue { get ; set ; }
        public List<string> Notes { get ; set ; }
        public bool Client { get ; set ; }
        public bool Lead { get ; set ; }
        public bool Active { get ; set ; }
        public bool Inactive { get ; set ; }
        public bool Dead { get ; set ; }
        public DateTime ChangedToClient { get ; set ; }
        public DateTime ChangedToLead { get ; set ; }
        public DateTime ChangedToActive { get ; set ; }
        public DateTime ChangedToInactive { get ; set ; }
        public DateTime ChangedToDead { get ; set ; }
        public int Number { get; }
        public Decimal FilingFee { get; set; }
        public String Jurisdiction { get; set; }
        public IState JurisdictionState { get; set; }
        public String Comment { get; set; }
        public List<IDebtor> AssignedDebtors { get ; set ; }

        /// <summary>
        /// Assign the specified account to this attorney. This issues an
        /// assign message on behalf of the debtor that is sent to the 
        /// attorney. The debtor's message queue is locked (the debtor will
        /// only process messages that are higher priority than the wait
        /// request sitting in the queue).
        /// </summary>
        /// <param name="DebtorToAssign"></param>
        /// <returns>True if the successful</returns>
        public bool Assign(IDebtor DebtorToAssign)
        {
            AssignedDebtors.Add (DebtorToAssign);
            return false;
        }

        /// <summary>
        /// Request that an account be recalled from the attorney. Due to
        /// the nature of the relationship with attorneys, this is not 
        /// guaranteed to go anywhere, so the replies can vary
        /// </summary>
        /// <param name="DebtorToAssign"></param>
        /// <returns></returns>
        public bool Recall(IDebtor DebtorToAssign)
        {
            throw new NotImplementedException();
        }
    }
}
