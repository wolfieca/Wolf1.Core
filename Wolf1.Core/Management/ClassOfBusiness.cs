using System;
using System.Collections.Generic;
using System.Text;

namespace Wolf1.Core.Management
{
    public record ClassOfBusiness
    {
        public string COBCode { get;  }
        public string Title { get;  }
        public bool IncludeInCreditReports { get;  }
    }
}
