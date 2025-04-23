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

        public AccessControlList ACL { get => ACL; private set => ACL = value; }
        public string TransactionID { get => TransactionID; private set => TransactionID = value; }
        public User Originator { get => Originator; private set => Originator = value; }
        public User ApprovedBy { get => ApprovedBy; privaate set => ApprovedBy = value; }
        public GLAccount Account { get => Account; private set => Account = value; }
        public DateTime TransactionDate { get => TransactionDate; private set => TransactionDate = value; }
        public DateTime ApprovalDate { get => ApprovalDate; private set => ApprovalDate = value; }
        public DateTime PostDate { get => PostDate; private set => PostDate = value; }
        public Decimal Credits { get => Credits; private set => Credits = value; }
        public Decimal Debits { get => Debits; private set => Debits = value; }
        public Transaction Reference { get => Reference; private set => Reference = value;
        public string Memo { get => Memo; private set => Memo = value; }

        
    }
}
