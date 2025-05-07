using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public class ClassOfBusiness
    {
        public string COBCode { get; private set; }
        public string Title { get; private set; }
        public bool IncludeInCreditReports { get; private set; }
    }
}
