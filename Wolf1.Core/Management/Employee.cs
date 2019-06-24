using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Document;

namespace Wolf1.Core.Management
{
    class Employee : IEmployee
    {
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
    }
}
