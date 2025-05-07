using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.MessageQueues;

namespace Wolf1.Core.Management
{
    public class Forwarder : IAssignee
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
        public IState JurisdictionState { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IDebtor> AssignedDebtors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Assign the specified debtor to this forwarder. A debtor message will be sent 
        /// to the forwarder, locking the debtor's queue as long as the account is with
        /// the forwader. The debtor at this point will only respond to payment messages,
        /// and a small subset of messages such as demographics changes (which get forwarded
        /// to the forwarder as well).
        /// </summary>
        /// <param name="DebtorToAssign"></param>
        /// <returns>True if successful</returns>
        public bool Assign(IDebtor DebtorToAssign)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Pull the specified debtor back from the forwarder. A recall message is sent
        /// to the forwarder and, once it is acknowledged, the debtor's queue will be
        /// unlocked for further processing. Recall messagescan be sent by either the 
        /// company, or the forwarder. The company, because of its place in the scheme
        /// of things, can issue Recall debtors from any forwarder, while forwarders
        /// can only issue them for debtors that have been forwarded to them.
        /// </summary>
        /// <param name="DebtorToAssign">True if successful</param>
        /// <returns></returns>
        public bool Recall(IDebtor DebtorToAssign)
        {
            throw new NotImplementedException();
        }
    }
}
