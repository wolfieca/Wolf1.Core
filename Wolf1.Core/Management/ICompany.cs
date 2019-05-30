using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    interface ICompany
    {
        string Name { get; set; }
        IAddress CompanyAddress { get; set; }
        ICompany Parent { get; set; }
        IClassOfBusiness BusinessClass { get; set; }
        DateTime AddDate { get; set; }
        IUser AddUser { get; set; }
        DateTime UpdateDate { get; set; }
        IUser UpdateUser { get; set; }
        Dictionary<String, IPhoneNumber> PhoneNumber { get; set; }
        Dictionary<String,ICompanyHours> Hours { get; set; }
        Boolean AllowMarketingMaterials { get; set; }
        IAddress PhysicalAddress { get; set; }
        IAddress MailingAddress { get; set; }
        List<IContact> Contacts { get; set; }
        IHistory History { get; set; }
        MessageQueues.IMessageQueue CompanyQueue { get; set; }
        List<String> Notes { get; set; }
        Boolean Client { get; set; }
        Boolean Lead { get; set; }
        Boolean Active { get; set; }
        Boolean Inactive { get; set; }
        Boolean Dead { get; set; }
        DateTime ChangedToClient { get; set; }
        DateTime ChangedToLead { get; set; }
        DateTime ChangedToActive { get; set; }
        DateTime ChangedToInactive { get; set; }
        DateTime ChangedToDead { get; set; }
    }
}
