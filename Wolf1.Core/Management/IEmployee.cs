using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Document;

namespace Wolf1.Core.Management
{
    public interface IEmployee : IPerson
    {
        IOffice Office { get; set; }
        int EmployeeID { get; set; }
        IUser SystemUser { get; set; }
        Dictionary<String, IDocument> OnboardingDocuments { get; set; }
        Dictionary<String, IWorkHours> DefaultWorkSchedule { get; set; }
        DateTime StartDate { get; set; }
        DateTime TerminationDate { get; set; }
        IEmployee Supervisor { get; set; }
        IPhoneNumber WorkPhone { get; set; }
        IEmailAddress WorkEmailAddress { get; set; }
        Boolean Fulltime { get; set; }
        History History { get; set; }

    }
}
