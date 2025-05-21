using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Document;

namespace Wolf1.Core.Management
{
    public interface IEmployee : IPerson
    {
        IOffice Office { get; }
        int EmployeeID { get; }
        IUser SystemUser { get; }
        Dictionary<String, IDocument> OnboardingDocuments { get; }
        Dictionary<String, IWorkHours> DefaultWorkSchedule { get; }
        DateTime StartDate { get; }
        DateTime TerminationDate { get; }
        IEmployee Supervisor { get; }
        IPhoneNumber WorkPhone { get; }
        IEmailAddress WorkEmailAddress { get; }
        Boolean Fulltime { get; }
        Boolean CanBeRehired { get; }
        History History { get; }
    }
}
