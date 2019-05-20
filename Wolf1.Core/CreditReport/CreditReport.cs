using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Management;

namespace Wolf1.Core.CreditReport
{
    class CreditReport : ICreditReport, IBaseObject
    {
        public AccessControlList ACL { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
