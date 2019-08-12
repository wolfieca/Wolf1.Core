using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.MessageQueues;

namespace Wolf1.Core.Management
{
    class Attorney : IAssignee
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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
        public IHistory History { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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
        public int Number { get; }
        public Decimal FilingFee { get; set; }
        public String Jurisdiction { get; set; }
        public IState JurisdictionState { get; set; }
        public String Comment { get; set; }
        public List<IDebtor> AssignedDebtors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
            throw new NotImplementedException();
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
