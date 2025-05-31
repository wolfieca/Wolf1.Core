using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public interface ICompany
    {
        string Name { get;  }
        IAddress CompanyAddress { get;  }
        ICompany Parent { get;  }
        IClassOfBusiness BusinessClass { get;  }
        DateTime AddDate { get;  }
        IUser AddUser { get;  }
        DateTime UpdateDate { get;  }
        IUser UpdateUser { get;  }
        Dictionary<String, IPhoneNumber> PhoneNumber { get;  }
        Dictionary<String,ICompanyHours> Hours { get;  }
        Boolean AllowMarketingMaterials { get;  }
        IAddress PhysicalAddress { get;  }
        IAddress MailingAddress { get;  }
        List<IContact> Contacts { get;  }
        IHistory History { get;  }
        MessageQueues.IMessageQueue CompanyQueue { get;  }
        List<String> Notes { get;  }
        Boolean Client { get;  }
        Boolean Lead { get;  }
        Boolean Active { get;  }
        Boolean Inactive { get;  }
        Boolean Dead { get;  }
        DateTime ChangedToClient { get;  }
        DateTime ChangedToLead { get;  }
        DateTime ChangedToActive { get;  }
        DateTime ChangedToInactive { get;  }
        DateTime ChangedToDead { get;  }
    }
}
