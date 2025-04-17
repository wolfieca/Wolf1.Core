using System;
using System.Collections.Generic;
using System.Text;
using Wolf1.Core.Management;

namespace Wolf1.Core.Accounting
{
    class GLAccount : IBaseObject
    {
        public AccessControlList ACL { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int AccountNumber { get => AccountNumber; set => AccountNumber = value; }
        public string Comments { get=>Comments; set => Comments = value; }
        public TransactionRegister Transactions { get => Transactions; set => Transactions = value; }

    }
}
