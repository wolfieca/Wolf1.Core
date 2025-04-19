using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Wolf1.Core.Management;

namespace Wolf1.Core.Accounting
{
    /// <summary>
    /// A single transaction
    /// </summary>
    class Transaction : IBaseObject
    {
        public AccessControlList ACL { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public User Originator { get => Originator; private set => Originator = value; }
        public DateTime TransactionDate { get => TransactionDate; private set => TransactionDate = value; }
        public ArrayList SubTransactions { get => SubTransactions; private set => SubTransactions = value;}
        public Decimal TotalCredits { get => TotalCredits; private set => TotalCredits = value; }
        public Decimal TotalDebits { get => TotalDebits; private set => TotalDebits = value; }
    }
}
